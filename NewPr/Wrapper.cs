using System;

namespace NewPr
{
	public class Wrapper
	{
		SimpleCalculatorService simpleCalc;
		MyPage myPage;

		public Wrapper (MyPage myPage)
		{
			this.simpleCalc = new SimpleCalculatorService ();
			this.myPage = myPage;
			this.myPage.operatorEvent += new EventHandler(MyPage_operatorEvent);
			this.myPage.equelsEvent += new EventHandler (MyPage_equelsEvent);
		}


		void MyPage_operatorEvent (object sender, EventArgs e)
		{
			this.simpleCalc.

		}

		void MyPage_equelsEvent (object sender, EventArgs e)
		{
			this.myPage.
		}

	}
}

