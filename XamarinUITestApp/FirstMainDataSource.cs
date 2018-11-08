using Foundation;
using System;
using System.Collections.Generic;
using UIKit;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace XamarinUITestApp
{
    public class FirstMainDataSource : UITableViewSource
    {
        string[] dataSet;
        string CellIdentifier = "TableCell";
        ItemListViewController _ItemListControl;
        DetailTabBarController _detailTabs;

        public FirstMainDataSource(string[] data, UIViewController home)
        {
            dataSet = data;
            HomeScreen = home;
            Initialize();
        }

        private UIViewController homeScreen = null;

        public UIViewController HomeScreen { get => homeScreen; set => homeScreen = value; }

        void Initialize()
        {
            _ItemListControl = homeScreen.Storyboard.InstantiateViewController("ItemListViewController") as ItemListViewController;
            _detailTabs = homeScreen.Storyboard.InstantiateViewController("DetailTabBarController") as DetailTabBarController;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            UITableViewCell cell = tableView.DequeueReusableCell(CellIdentifier);
            string item = dataSet[indexPath.Row];

            if (cell == null)
            {
                cell = new UITableViewCell(UITableViewCellStyle.Default, CellIdentifier);
                cell.UserInteractionEnabled = true;

            }

            cell.TextLabel.Text = item;

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return dataSet.Length;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            try
            {
                if (_ItemListControl != null)
                {

                    tableView.DeselectRow(indexPath, true);

                    if (dataSet[indexPath.Row] == "Tab Test" && _detailTabs != null)
                    {
                        Analytics.TrackEvent("Menu - Tab Test");
                        homeScreen.NavigationController.PushViewController(_detailTabs, true);
                    }
                    else if (dataSet[indexPath.Row] == "Crash" && _detailTabs != null)
                    {
                        Analytics.TrackEvent("Menu - Crash");
                        Crashes.GenerateTestCrash();
                    }
                    else
                    {
                        Analytics.TrackEvent(string.Format("Menu - {0}", dataSet[indexPath.Row]));
                        _ItemListControl.Mode = dataSet[indexPath.Row];

                        homeScreen.NavigationController.PushViewController(_ItemListControl, true);
                    }
                }
            }
            catch (Exception ex)
            {
                Crashes.TrackError(ex);
            }
        }

        public override bool CanEditRow(UITableView tableView, NSIndexPath indexPath)
        {
            return false;
        }

        public override void CommitEditingStyle(UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
        {
            switch (editingStyle)
            {
                case UITableViewCellEditingStyle.Delete:
                    List<string> tmp = new List<string>(dataSet);
                    tmp.RemoveAt(indexPath.Row);
                    dataSet = tmp.ToArray();

                    tableView.DeleteRows(new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);
                    break;
                case UITableViewCellEditingStyle.Insert:

                    break;
                case UITableViewCellEditingStyle.None:
                    break;
            }
        }

        //public override UITableViewCellEditingStyle EditingStyleForRow(UITableView tableView, NSIndexPath indexPath)
        //{
        //    return base.EditingStyleForRow(tableView, indexPath);
        //}

    }
}
