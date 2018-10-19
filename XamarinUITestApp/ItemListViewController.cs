using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace XamarinUITestApp
{
    public partial class ItemListViewController : UITableViewController
    {
        string _mode = String.Empty;

        public ItemListViewController (IntPtr handle) : base (handle)
        {
            this.Title = "Item List";
        }

        public string Mode { get => _mode; set => _mode = value; }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            List<string> data = new List<string>();
            for (int i = 0; i < 10; ++i)
            {
                data.Add(string.Format("Item {0}", i.ToString()));
            }

            TableView.Source = new ItemListDataSource(data.ToArray(), this);
            TableView.RowHeight = UITableView.AutomaticDimension;
            TableView.EstimatedRowHeight = 40f;
            TableView.ReloadData();
        }
    }
}