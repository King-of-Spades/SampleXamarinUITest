using System;
using Foundation;
using UIKit;

namespace XamarinUITestApp
{
    public class ItemListDataSource : UITableViewSource
    {
        string[] _data;
        string[] _sections;
        UIViewController _controller;
        Action<UIAlertAction> _okAction;
        DetailViewController _itemViewController;

        public ItemListDataSource(string[] dataSet, UIViewController controller)
        {
            _data = dataSet;
            _sections = new[] { "Test" };
            _controller = controller;
            _itemViewController = _controller.Storyboard.InstantiateViewController("DetailViewController") as DetailViewController;

            _okAction = this.OkAlert_Action;
        }

        public void OkAlert_Action(UIAlertAction obj)
        {
            _controller.NavigationController.PushViewController(_itemViewController, true);
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            ListItemTableViewCell cell = (ListItemTableViewCell)tableView.DequeueReusableCell("celSubTable", indexPath);

            cell.UpdateCell(indexPath.Row == 4);

            cell.IsAccessibilityElement = true;
            cell.AccessibilityIdentifier = string.Format("itm{0}", indexPath.Row.ToString());

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _data.Length;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            tableView.DeselectRow(indexPath, true);

            if (indexPath.Row == 4)
            {
                UIAlertController okAlertController = UIAlertController.Create("test", "Hello World", UIAlertControllerStyle.Alert);
                okAlertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Default, _okAction));
                okAlertController.AddAction(UIAlertAction.Create("Cancel", UIAlertActionStyle.Cancel, null));

                _controller.PresentViewController(okAlertController, true, null);
            }
            else
            {
                _controller.NavigationController.PushViewController(_itemViewController, true);
            }
        }

        public override nint NumberOfSections(UITableView tableView)
        {
            return 1;
        }

        public override string TitleForHeader(UITableView tableView, nint section)
        {
            return _sections[section];
        }
    }
}
