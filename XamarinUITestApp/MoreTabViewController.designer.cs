// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamarinUITestApp
{
    [Register ("MoreTabViewController")]
    partial class MoreTabViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView pklTest { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView pklTest2 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (pklTest != null) {
                pklTest.Dispose ();
                pklTest = null;
            }

            if (pklTest2 != null) {
                pklTest2.Dispose ();
                pklTest2 = null;
            }
        }
    }
}