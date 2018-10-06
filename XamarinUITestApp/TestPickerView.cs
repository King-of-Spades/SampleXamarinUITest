using System;
using UIKit;

namespace XamarinUITestApp
{
    public class TestPickerView : UIPickerViewModel
    {
        public TestPickerView()
        {
        }

        public override nint GetComponentCount(UIPickerView pickerView)
        {
            return 1;
        }

        public override string GetTitle(UIPickerView pickerView, nint row, nint component)
        {
            string rt = "Select Item";

            if (row > 0)
                rt = "Test";

            return rt;
        }

        public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
        {
            return 5;
        }
    }
}
