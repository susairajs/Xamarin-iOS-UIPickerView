using UIKit;
using System.Collections.Generic;
using System;

namespace XamariniOSUIPicker
{
	public class CountyPickerModel : UIPickerViewModel
	{
		List<string> Country;
		public EventHandler ValueChanged;
		public string SelectedValue;
		public CountyPickerModel(List<string> Country)
		{
			this.Country = Country;
		}

		public override nint GetRowsInComponent(UIPickerView pickerView, nint component)
		{
			return Country.Count;
		}

		public override nint GetComponentCount(UIPickerView pickerView)
		{
			return 1;
		}
		public override string GetTitle(UIPickerView pickerView, nint row, nint component)
		{
			return Country[(int) row];
		}
		public override void Selected(UIPickerView pickerView, nint row, nint component)
		{
			var country = Country[(int)row];

			SelectedValue = country;
			ValueChanged?.Invoke(null, null);


		}
	}
}