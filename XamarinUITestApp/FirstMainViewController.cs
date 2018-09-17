using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace XamarinUITestApp
{
    public partial class FirstMainViewController : UITableViewController
    {
        Controls.AdControl _ad;
        
        public FirstMainViewController(IntPtr handle) 
            : base(handle)
        {
            _ad = new Controls.AdControl(handle);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            string[] values = new string[] { "Fencers", "Bouts", "Tab Test" };

            this.TableView.AllowsSelection = true;
            this.TableView.Source = new FirstMainDataSource(values, this);

            //this.TableView.SeparatorStyle = UITableViewCellSeparatorStyle.DoubleLineEtched;
            this.TableView.SeparatorEffect = UIBlurEffect.FromStyle(UIBlurEffectStyle.Dark);

            //this.TableView.TableFooterView.AddSubview(_ad);
        }

    }

}