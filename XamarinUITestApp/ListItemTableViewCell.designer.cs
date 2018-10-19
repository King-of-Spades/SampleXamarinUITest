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
    [Register ("ListItemTableViewCell")]
    partial class ListItemTableViewCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblLabel1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblLabel2 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblLabel3 { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblLabel1 != null) {
                lblLabel1.Dispose ();
                lblLabel1 = null;
            }

            if (lblLabel2 != null) {
                lblLabel2.Dispose ();
                lblLabel2 = null;
            }

            if (lblLabel3 != null) {
                lblLabel3.Dispose ();
                lblLabel3 = null;
            }
        }
    }
}