using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NewPr
{
	public partial class MyPage : ContentPage
	{
		private bool operation_pressed = false, equals_pressed = false;

		public MyPage ()
		{
			InitializeComponent ();
		}

		public event EventHandler operatorEvent = null;
		public event EventHandler equelsEvent = null;

		private void OnButtonClicked(object sender, System.EventArgs e)
		{
			if ((Output.Text == "0") || operation_pressed || equals_pressed || (Output.Text == "На ноль делить нельзя!"))
				Output.Text = "";
			
			Button button = (Button)sender;
			Output.Text += button.Text;
			equals_pressed = false;
			operation_pressed = false;



		}

		private void OnCEClicked(object sender, System.EventArgs e)
		{
			Output.Text = "0";
		}

		private void OnCClicked(object sender, System.EventArgs e)
		{
			value = 0;
			Output.Text = "0";
		}

		private void OnOperatorClicked(object sender, System.EventArgs e)
		{
			operation_pressed = true;
			buttonEvent.Invoke (sender,e);
		}

		private void OnEquelsClicked(object sender, System.EventArgs e)
		{
			equals_pressed = true;
			equelsEvent.Invoke (sender,e);
		}
	}
}

