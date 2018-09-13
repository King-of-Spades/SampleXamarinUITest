using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace XamarinUITestApp
{
    public partial class FirstMainViewController : UITableViewController
    {
        
        public FirstMainViewController(IntPtr handle) 
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            string[] values = new string[] { "Fencers", "Bouts", "Tab Test" };

            this.TableView.AllowsSelection = true;
            this.TableView.Source = new FirstMainDataSource(values, this);
        }

    }

}