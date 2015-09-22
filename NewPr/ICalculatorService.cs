using System;

namespace NewPr
{
	public interface ICalculatorService
	{
		double Summ(double x, double y);
		double Diff(double x, double y);
		double Multi(double x, double y);
		double Div (double x, double y);
		double Equals(double x, double y, string operation);
	}
}

