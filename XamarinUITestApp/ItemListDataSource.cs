using System;
using Foundation;
using UIKit;

namespace XamarinUITestApp
{
    public class ItemListDataSource : UITableViewSource
    {
        string[] _data;
        UIViewController _controller;
        DetailViewController _detailViewController;

        public ItemListDataSource(string[] dataSet, UIViewController controller)
        {
            _data = dataSet;
            _controller = controller;

            _detailViewController = _controller.Storyboard.InstantiateViewController("DetailViewController") as DetailViewController;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            ListItemTableViewCell cell = (ListItemTableViewCell)tableView.DequeueReusableCell("celSubTable", indexPath);

            cell.UpdateCell();

            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return _data.Length;
        }

        public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
        {
            if (_detailViewController != null)
            {
                tableView.DeselectRow(indexPath, true);

                _controller.NavigationController.PushViewController(_detailViewController, true);
            }
        }
    }
}
