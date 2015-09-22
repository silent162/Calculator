using System;

namespace NewPr
{
	public class SimpleCalculatorService
	{
		public double Summ(double x, double y)
		{
			return x + y;
		}

		public double Diff(double x, double y)
		{
			return x - y;
		}

		public double Multi(double x, double y)
		{
			return x * y;
		}

		public double Div(double x, double y)
		{
			if (y == 0)
				return 0;
			else
			    return x / y;
		}

		public double Equals(double x, double y, string operation)
		{
			switch (operation)
			{
			case "+":
				return Summ(x,y);
			case "-":
				return Diff(x,y);
			case "*":
				return Multi(x,y);
			case "/":
				return Div(x,y);
     		default:
				return 0;
			}
		 }

	}
}

