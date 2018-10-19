using System;
using Foundation;
using UIKit;

namespace XamarinUITestApp
{
    public class ItemListDataSource : UITableViewSource
    {
        string[] _data;
        UIViewController _controller;

        public ItemListDataSource(string[] dataSet, UIViewController controller)
        {
            _data = dataSet;
            _controller = controller;
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
    }
}
