using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace Calculator_CSharp.Models
{
	public class Calculator
	{
		public decimal LeftOperand { get; set; }

		public decimal RightOperand { get; set; }

		public string Operator { get; set; }

		public decimal Result { get; set; }

		public Calculator()
		{
			Result = 0;
		}

		public decimal CalculateResult()
		{
			decimal result = 0m;

			switch (Operator)
			{
				case "+":
					result = LeftOperand + RightOperand;
					break;
				case "-":
					result = LeftOperand - RightOperand;
					break;
				case "*":
					result = LeftOperand * RightOperand;
					break;
				case "/":
					result = LeftOperand / RightOperand;
					break;
			}

			return result;
		}
	}
}