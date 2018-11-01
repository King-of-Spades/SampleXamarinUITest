//using Foundation;
using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace XamarinUITestApp
{
    public partial class DetailViewController : UIViewController
    {
        UITextField _value1;
        UITextField _value2;

        public DetailViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "Detail View";
            NavigationController.NavigationBar.Translucent = false;

            //SetupScreenControls();
            SetupScreenStack();

            SetValues();
        }

        void SetValues()
        {
            _value1.Text = "Value 1";
            _value2.Text = "Value 2";
        }

        void SetupScreenStack()
        {
            UILayoutGuide margin = View.LayoutMarginsGuide;

            List<UIView> rows = new List<UIView>();

            _value1 = GetTextField("Enter text");
            List<UIView> cells = new List<UIView>
            {
                GetLabel("Test Label"),
                _value1
            };

            rows.Add(GetStackViewRow(cells.ToArray()));

            _value2 = GetTextField();
            cells = new List<UIView>
            {
                GetLabel("Row 2"),
                _value2
            };

            rows.Add(GetStackViewRow(cells.ToArray()));

            cells = new List<UIView>()
            {
                GetLabel("Date Picker")
            };

            rows.Add(GetStackViewRow(cells.ToArray()));

            cells = new List<UIView>()
            {
                GetDatePicker()
            };

            rows.Add(GetStackViewRow(cells.ToArray()));

            UIStackView tbl = new UIStackView(rows.ToArray())
            {
                BackgroundColor = UIColor.Gray,
                Alignment = UIStackViewAlignment.Fill,
                Axis = UILayoutConstraintAxis.Vertical,
                Distribution = UIStackViewDistribution.Fill,
                Spacing = 10f,
                TranslatesAutoresizingMaskIntoConstraints = false
            };

            UIScrollView scrollView = new UIScrollView(View.LayoutMarginsGuide.LayoutFrame)
            {
                //BackgroundColor = UIColor.Orange,
                ScrollEnabled = true,
                TranslatesAutoresizingMaskIntoConstraints = false
            };

            scrollView.AddSubview(tbl);

            View.AddSubview(scrollView);

            scrollView.LeadingAnchor.ConstraintEqualTo(margin.LeadingAnchor).Active = true;
            scrollView.TrailingAnchor.ConstraintEqualTo(margin.TrailingAnchor).Active = true;
            scrollView.TopAnchor.ConstraintEqualTo(margin.TopAnchor, 5f).Active = true;
            scrollView.HeightAnchor.ConstraintEqualTo(View.HeightAnchor).Active = true;
            scrollView.WidthAnchor.ConstraintEqualTo(margin.WidthAnchor).Active = true;

        }

        UILabel GetLabel(string text)
        {
            UILabel rt = new UILabel()
            {
                Text = text,
                TranslatesAutoresizingMaskIntoConstraints = false
            };

            return rt;
        }

        UITextField GetTextField(string placeHolder = null)
        {
            UITextField rt = new UITextField()
            {
                Placeholder = placeHolder ?? string.Empty,
                AutosizesSubviews = false,
                TextAlignment = UITextAlignment.Left,
                BorderStyle = UITextBorderStyle.RoundedRect,
                ClearButtonMode = UITextFieldViewMode.WhileEditing,
                ReturnKeyType = UIReturnKeyType.Done,
                TranslatesAutoresizingMaskIntoConstraints = false
            };

            rt.WidthAnchor.ConstraintEqualTo(150f).Active = true;

            return rt;
        }

        UIStackView GetStackViewRow(UIView[] entries)
        {
            UIStackView rt = new UIStackView(entries)
            {
                //BackgroundColor = UIColor.LightGray,
                Alignment = UIStackViewAlignment.Fill,
                Axis = UILayoutConstraintAxis.Horizontal,
                Distribution = UIStackViewDistribution.Fill,
                Spacing = 10f,
                TranslatesAutoresizingMaskIntoConstraints = false
            };

            return rt;
        }

        UIDatePicker GetDatePicker()
        {
            UIDatePicker rt = new UIDatePicker();

            return rt;
        }

        void SetupScreenControls()
        {
            UILayoutGuide margin = View.LayoutMarginsGuide;

            UIScrollView scrollView = new UIScrollView(View.Frame)
            {
                BackgroundColor = UIColor.White, //new UIColor(red: 0.0f,green: 0.0f, blue: 0.95f, alpha: 0.5f)
                ScrollEnabled = true
            };

            View.AddSubview(scrollView);

            UIStackView rows = new UIStackView(scrollView.Frame)
            {
                Alignment = UIStackViewAlignment.Fill,
                Axis = UILayoutConstraintAxis.Vertical,
                Distribution = UIStackViewDistribution.FillEqually,
                Spacing = 5f,
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            scrollView.AddSubview(rows);

            UILabel label = new UILabel()
            {
                Text = "Hello World",
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            label.Font.WithSize(40f);
            scrollView.AddSubview(label);

            label.LeadingAnchor.ConstraintEqualTo(margin.LeadingAnchor).Active = true;
            label.TrailingAnchor.ConstraintEqualTo(margin.TrailingAnchor).Active = true;
            label.TopAnchor.ConstraintEqualTo(margin.TopAnchor, 5f).Active = true;
            label.HeightAnchor.ConstraintEqualTo(15f).Active = true;
            label.WidthAnchor.ConstraintEqualTo(50f).Active = true;


            UILabel label1 = new UILabel()
            {
                Text = "Test Label",
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            label1.Font.WithSize(40f);
            scrollView.AddSubview(label1);

            label1.LeadingAnchor.ConstraintEqualTo(margin.LeadingAnchor).Active = true;
            label1.TrailingAnchor.ConstraintEqualTo(margin.TrailingAnchor).Active = true;
            label1.TopAnchor.ConstraintEqualTo(label.BottomAnchor, 10f).Active = true;
            label1.HeightAnchor.ConstraintEqualTo(label.HeightAnchor).Active = true;
            label1.WidthAnchor.ConstraintEqualTo(label.WidthAnchor).Active = true;


            UILabel largeLabel = new UILabel()
            {
                BackgroundColor = UIColor.LightGray,
                Text = "Large Text",
                TranslatesAutoresizingMaskIntoConstraints = false
            };
            largeLabel.Font.WithSize(200f);
            scrollView.AddSubview(largeLabel);

            largeLabel.LeadingAnchor.ConstraintEqualTo(margin.LeadingAnchor).Active = true;
            largeLabel.TrailingAnchor.ConstraintEqualTo(margin.TrailingAnchor).Active = true;
            largeLabel.TopAnchor.ConstraintEqualTo(label1.BottomAnchor, 10f).Active = true;
            largeLabel.HeightAnchor.ConstraintEqualTo(250f).Active = true;

            //NSMutableDictionary views = new NSMutableDictionary();
            //views.Add(new NSString("label"), label);

            //string format = "|-[label]-|";
            //NSLayoutConstraint[] constraints = NSLayoutConstraint.FromVisualFormat(format, NSLayoutFormatOptions.AlignAllTop, null, views);
            //NSLayoutConstraint.ActivateConstraints(constraints);
            //}

        }

    }
}