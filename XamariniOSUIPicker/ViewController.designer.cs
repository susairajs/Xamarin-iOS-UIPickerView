// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamariniOSUIPicker
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIPickerView CountryPicker { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblValue { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (CountryPicker != null) {
                CountryPicker.Dispose ();
                CountryPicker = null;
            }

            if (lblValue != null) {
                lblValue.Dispose ();
                lblValue = null;
            }
        }
    }
}