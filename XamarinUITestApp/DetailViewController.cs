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

            UILabel label = new UILabel
            {
                Text = "Test Label",
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            label.Font.WithSize(40);

            this.View.Add(label);

            //this.View.AddConstraints(new[] {
            //    NSLayoutConstraint.Create(label, NSLayoutAttribute.Width, NSLayoutRelation.Equal, View, NSLayoutAttribute.Width, 1, 0),
            //    NSLayoutConstraint.Create(label, NSLayoutAttribute.Height, NSLayoutRelation.Equal, View, NSLayoutAttribute.NoAttribute, 1, 50),
            //    NSLayoutConstraint.Create(label, NSLayoutAttribute.Top, NSLayoutRelation.Equal, View, NSLayoutAttribute.Top, 1, 20),
            //    NSLayoutConstraint.Create(label, NSLayoutAttribute.Left, NSLayoutRelation.Equal, View, NSLayoutAttribute.Left, 1, 0)
            //});
        }
    }
}