using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NewPr
{
	public partial class MyPage : ContentPage
	{
		private bool operation_pressed = false;
		private bool point_pressed = false;
		Button button;

		public string Str{get;set;}
		public bool Button_pressed{get;set;}

		public MyPage ()
		{
			InitializeComponent ();
			new Wrapper (this);
		}

		public event EventHandler operatorEvent = null;

		private void OnButtonClicked(object sender, System.EventArgs e)
		{
			button = (Button)sender;
			Button_pressed = true;

			//Условие если первой нажали кнопку "."
			if (button.Text == "." && Output.Text == "0")
			{
				point_pressed = true;
				Output.Text = "0.";
			}

			//Очищение Output 
			if ((Output.Text == "0") || operation_pressed || (Output.Text == "На ноль делить нельзя!"))
				Output.Text = "";

			//Фильтр на нажатие кнопки "."
			if (point_pressed == false && button.Text == ".") 
			{				
				Output.Text += button.Text;
				point_pressed = true;

			} 
			else if (point_pressed == true && button.Text != ".")
					Output.Text += button.Text;
			else if (button.Text != ".")
				    Output.Text += button.Text;

			operation_pressed = false;

		}

		private void OnCEClicked(object sender, System.EventArgs e)
		{
			Output.Text = "0";
			point_pressed = false;
		}

		private void OnCClicked(object sender, System.EventArgs e)
		{
			Output.Text = "0";
			point_pressed = false;
			new Wrapper ().Value = 0;
		}

		private void OnOperatorClicked(object sender, System.EventArgs e)
		{
			operation_pressed = true;

			//Проверка на значения 5. +
			if (Button_pressed && button.Text == ".")
				Str = Output + "0";
			else
			Str = Output.Text;
			
			point_pressed = false;
			operatorEvent.Invoke (sender,e);
			Output.Text = Str;
		}

	}
}

