using Foundation;
using System;
using UIKit;

namespace XamarinUITestApp
{
    public partial class ListItemTableViewCell : UITableViewCell
    {
        public ListItemTableViewCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateCell()
        {
            this.lblLabel1.Text = "Hello - L1";
            this.lblLabel2.Text = "Hi - L2";
            this.lblLabel3.Text = "Ola - L3";
        }
    }
}