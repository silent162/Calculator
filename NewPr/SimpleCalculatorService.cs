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

		public double Equels(double x, double y, string operation)
		{
			switch (operation)
			{
			case "+":
				return Summ(x,y);
				break;
			case "-":
				return Diff(x,y);
				break;
			case "*":
				return Multi(x,y);
				break;
			case "/":
				return Div(x,y);
				break;
			default:
				return 0;
				break;

			}
		 }

	}
}

