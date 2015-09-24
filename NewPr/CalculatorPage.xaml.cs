using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Calculator
{
	public partial class CalculatorPage : ContentPage
	{
		private bool operation_pressed = false;
		private bool point_pressed = false;
		Button button;

		public string Str{get;set;}
		public bool Button_pressed{get;set;}

		public CalculatorPage ()
		{
			InitializeComponent ();
			new Wrapper (this);
		}

		public event EventHandler operatorEvent = null;

		private void OnButtonClicked(object sender, System.EventArgs e)
		{
			button = (Button)sender;
			Button_pressed = true;

			//Проверка, если первой нажали кнопку "."
			if (button.Text == "." && Output.Text == "0" || operation_pressed && button.Text == ".")
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

		// Обнуляет последее введенное значение
		private void OnCEClicked(object sender, System.EventArgs e)
		{
			Output.Text = "0";
			point_pressed = false;
		}

		//Полностью обнуляет все значения
		private void OnCClicked(object sender, System.EventArgs e)
		{
			Output.Text = "0";
			point_pressed = false;
			operation_pressed = false;
			Button_pressed = false;
			Calculator.Wrapper.Value = 0;
			Calculator.Wrapper.Operation = "";
		}

		private void OnOperatorClicked(object sender, System.EventArgs e)
		{
			operation_pressed = true;
			Str = Output.Text;
			point_pressed = false;
			operatorEvent.Invoke (sender,e);
			Output.Text = Str;
		}

	}
}

