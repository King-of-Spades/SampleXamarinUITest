using Foundation;
using System;
using UIKit;

namespace XamarinUITestApp
{
    public partial class MoreTabViewController : UIViewController
    {
        public MoreTabViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            SetupPicker();
        }

        void SetupPicker()
        {

            this.pklTest.Model = new TestPickerView();
            this.pklTest2.Model = new TestPickerView();
        }
    }
}