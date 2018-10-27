using Foundation;
using System;
using UIKit;

namespace XamarinUITestApp
{
    public partial class DetailViewController : UIViewController
    {
        public DetailViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "Detail View";
        }
    }
}