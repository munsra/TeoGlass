// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace TeoGlass
{
    [Register ("ItemDashboardController")]
    partial class ItemDashboardController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel BlisterLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DoneButton1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel OtherLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel SystemLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (BlisterLabel != null) {
                BlisterLabel.Dispose ();
                BlisterLabel = null;
            }

            if (DoneButton1 != null) {
                DoneButton1.Dispose ();
                DoneButton1 = null;
            }

            if (OtherLabel != null) {
                OtherLabel.Dispose ();
                OtherLabel = null;
            }

            if (SystemLabel != null) {
                SystemLabel.Dispose ();
                SystemLabel = null;
            }
        }
    }
}