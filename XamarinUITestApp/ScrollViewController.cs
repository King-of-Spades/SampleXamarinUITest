using Foundation;
using System;
using UIKit;

namespace XamarinUITestApp
{
    public partial class ScrollViewController : UIViewController
    {
        public ScrollViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            UILabel label;
            //scvDetail.ContentMode = UIViewContentMode.TopLeft;

            for (int i = 0; i < 20; i++)
            {
                label = new UILabel
                {
                    Text = "ScrollView Test label"
                };
                label.Font.WithSize(35);
                this.View.AddSubview(label);
            }
        }

        public override void ViewDidLayoutSubviews()
        {
            //scvDetail.Frame = new CoreGraphics.CGRect(0, 0, this.View.Bounds.Width, this.View.Bounds.Height);
            //scvDetail.ContentSize = scvDetail.Frame.Size;
        }
    }
}