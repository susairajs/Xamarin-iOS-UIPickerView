using System;
using System.Collections.Generic;
using UIKit;

namespace XamariniOSUIPicker
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}
                // County List
		List<string> Country = new List<string>
		{
                  "America","Australia","Bangladesh","Canada","Colombia","China","Denmark","India"
		};

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.

			var picker = new CountyPickerModel(Country);
			CountryPicker.Model = picker;

			picker.ValueChanged += (sender, e) =>
			{
				//Set value to Lable
				lblValue.Text = picker.SelectedValue;
			};
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
