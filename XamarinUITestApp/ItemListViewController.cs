using Foundation;
using System;
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
    }
}