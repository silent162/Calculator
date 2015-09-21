using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NewPr
{
	public class Wrapper
	{
		SimpleCalculatorService simpleCalc;
		MyPage myPage;
		string operation;
		double value;

		public Wrapper (MyPage myPage)
		{
			this.simpleCalc = new SimpleCalculatorService ();
			this.myPage = myPage;
			this.myPage.operatorEvent += new EventHandler(MyPage_operatorEvent);
			this.myPage.equelsEvent += new EventHandler (MyPage_equelsEvent);
		}


		void MyPage_operatorEvent (object sender, EventArgs e)
		{
			Button b = (Button)sender; 
			operation = b.Text;
			value =	Convert.ToDouble (this.myPage.str);

		}

		void MyPage_equelsEvent (object sender, EventArgs e)
		{
			
			switch (operation) {
			case "+":
				this.myPage.str = Convert.ToString (this.simpleCalc.Summ(value, Convert.ToDouble (this.myPage.str)));
				break;
			case "-":
				this.myPage.str = Convert.ToString (this.simpleCalc.Diff(value, Convert.ToDouble (this.myPage.str)));
				break;
			case "*":
				this.myPage.str = Convert.ToString (this.simpleCalc.Multi(value, Convert.ToDouble (this.myPage.str)));
				break;
			case "/":
				if (this.myPage.str == "0")
					this.myPage.str = "На ноль делить нельзя!";
				else
					this.myPage.str = Convert.ToString (this.simpleCalc.Div(value, Convert.ToDouble (this.myPage.str)));
				break;

			}

		}

	}
}

