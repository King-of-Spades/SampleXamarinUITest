using System;
using System.ComponentModel;
using Foundation;
using UIKit;

namespace XamarinUITestApp.Controls
{
    [Register("AdControl"), DesignTimeVisible(true)]
    public class AdControl : UIView
    {
        public AdControl(IntPtr ptr)
            : base(ptr)
        {
            Initialize();
        }

        public AdControl()
        {
            Initialize();
        }

        void Initialize()
        {

        }
    }
}
