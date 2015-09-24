﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Calculator
{
	public class Wrapper
	{
		SimpleCalculatorService simpleCalc;
		CalculatorPage myPage;
	
		public static double Value {get;set;}
		public static string Operation {get;set;}

		public Wrapper(){}

		public Wrapper (CalculatorPage myPage)
		{
			this.simpleCalc = new SimpleCalculatorService ();
			this.myPage = myPage;
			this.myPage.operatorEvent += new EventHandler(MyPage_operatorEvent);
		}


		void MyPage_operatorEvent (object sender, EventArgs e)
		{
			Button b = (Button)sender;
			if (Value == 0)
				Value =	Convert.ToDouble (this.myPage.Str);

			//Проверка на нажатие кнопки с цифрой и реализация арифметических операций
			if (myPage.Button_pressed == true)
			{
				switch (Operation) 
				{
				case "+":
					myPage.Button_pressed = false;
								
					Value = this.simpleCalc.Summ(Value, Convert.ToDouble (this.myPage.Str));
					this.myPage.Str = Convert.ToString (Value);
					break;

				case "-":
					myPage.Button_pressed = false;

					Value = this.simpleCalc.Diff(Value, Convert.ToDouble (this.myPage.Str));
					this.myPage.Str = Convert.ToString (Value);
					break;

				case "*":
					myPage.Button_pressed = false;

					Value = this.simpleCalc.Multi(Value, Convert.ToDouble (this.myPage.Str));
					this.myPage.Str = Convert.ToString (Value);
					break;

				case "/":
					myPage.Button_pressed = false;

					if (this.myPage.Str == "0")
						this.myPage.Str = "На ноль делить нельзя!";
					else 
					{
						Value = this.simpleCalc.Div(Value, Convert.ToDouble (this.myPage.Str));
						this.myPage.Str = Convert.ToString (Value);
					}
					break;

				default:
					myPage.Button_pressed = false;
					break;
			    }
			}

			if (b.Text == "=")
			{
				if (this.myPage.Str != "На ноль делить нельзя!")					
				    this.myPage.Str = Convert.ToString (Value);
				
				Value = 0;
				Operation = "";
			}
			else
			Operation = b.Text;	

		}
    }
}
