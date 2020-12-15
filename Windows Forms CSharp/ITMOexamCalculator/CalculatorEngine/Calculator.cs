using System.Reflection;

namespace Calculator
{

	using System;

	public class CalcEngine
	{
		//
		// Operation Constants.
		//
		public enum Operator : int
		{
			eUnknown = 0,
			eAdd = 1,
			eSubtract = 2,
			eMultiply = 3,
			eDivide = 4,
			ePow = 5
		}

		//
		// Module-Level Constants
		//

		private static double negativeConverter = -1;
		// TODO: Upgrade the version number to 4.0.1.1
		private static string versionInfo = "Calculator v3.0.1.1";

		//
		// Module-level Variables.
		//

		private static double numericAnswer;
		private static string stringAnswer;
		private static Operator calcOperation;
		private static double firstNumber;
		private static double secondNumber;
		private static bool secondNumberAdded;
		private static bool decimalAdded;
		private static int facFirstNumber;

		//
		// Class Constructor.
		//

		public CalcEngine()
		{
			decimalAdded = false;
			secondNumberAdded = false;
		}

		//
		// Returns the custom version string to the caller.
		//

		public static string GetVersion()
		{
			return (versionInfo);
		}
		//
		// Called when the Date key is pressed.
		//

		public static string GetDate()
		{
			DateTime curDate = new DateTime();
			curDate = DateTime.Now;

			stringAnswer = String.Concat(curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

			return (stringAnswer);
		}

		public static string CalcSq()
        {
			if (stringAnswer != "")
            {
				firstNumber = System.Convert.ToDouble(stringAnswer);
				stringAnswer = System.Convert.ToString(firstNumber * firstNumber);
            }
			return (stringAnswer);
		}

		public static string CalcSqrt()
		{
			if (stringAnswer != "")
			{
				firstNumber = System.Convert.ToDouble(stringAnswer);
				stringAnswer = System.Convert.ToString(System.Math.Sqrt(firstNumber));
			}
			return (stringAnswer);
		}
		public static string CalcRec()
		{
			if (stringAnswer != "")
			{
				firstNumber = System.Convert.ToDouble(stringAnswer);
				stringAnswer = System.Convert.ToString(1 / firstNumber);
			}
			return (stringAnswer);
		}
		public static string CalcCbrt()
		{
			if (stringAnswer != "")
			{
				firstNumber = System.Convert.ToDouble(stringAnswer);
				stringAnswer = System.Convert.ToString(System.Math.Pow(firstNumber, 1 / 3f));
			}
			return (stringAnswer);
		}
		public static string CalcFact()
		{
			if (stringAnswer != "")
			{
				facFirstNumber = Math.Abs(System.Convert.ToInt32(stringAnswer));
				int f = 1;
				while (facFirstNumber > 1)
				{
					f *= facFirstNumber--;
				}
				stringAnswer = System.Convert.ToString(facFirstNumber);
			}
			return (stringAnswer);
		}


		//
		// Called when a number key is pressed on the keypad.
		//

		public static string CalcNumber (string KeyNumber)
		{
			stringAnswer = stringAnswer + KeyNumber;
			return (stringAnswer);
		}

		//
		// Called when an operator is selected (+, -, *, /, ^)
		//

		public static void CalcOperation (Operator calcOper)
		{
			if (stringAnswer != "" && !secondNumberAdded)
			{
				firstNumber = System.Convert.ToDouble (stringAnswer);
				calcOperation = calcOper;
				stringAnswer = "";
				decimalAdded = false;
			}			
		}

		//
		// Called when the +/- key is pressed.
		//

		public static string CalcSign ()
		{
			double numHold;

			if (stringAnswer != "")
			{
				numHold = System.Convert.ToDouble (stringAnswer);
				stringAnswer = System.Convert.ToString(numHold * negativeConverter);
			}
		
			return (stringAnswer);
		}

		//
		// Called when the . key is pressed.
		//

		public static string CalcDecimal ()
		{
			if (!decimalAdded && !secondNumberAdded)
			{
				if (stringAnswer != "")
					stringAnswer = stringAnswer + ".";
				else
					stringAnswer = "0.";

				decimalAdded = true;
			}

			return (stringAnswer);
		}

		//
		// Called when = is pressed.
		//

		public static string CalcEqual ()
		{
			bool validEquation = false;

			if (stringAnswer != "")
			{
				secondNumber = System.Convert.ToDouble (stringAnswer);
				secondNumberAdded = true;

				switch (calcOperation)
				{
					case Operator.eUnknown:
						validEquation = false;
						break;

					case Operator.eAdd:
						numericAnswer = firstNumber + secondNumber;
						validEquation = true;
						break;

					case Operator.eSubtract:
						numericAnswer = firstNumber - secondNumber;
						validEquation = true;
						break;

					case Operator.eMultiply:
						numericAnswer = firstNumber * secondNumber;
						validEquation = true;
						break;

					case Operator.eDivide:
						numericAnswer = firstNumber / secondNumber;
						validEquation = true;
						break;

					case Operator.ePow:
						numericAnswer = System.Math.Pow(firstNumber, secondNumber);
						validEquation = true;
						break;

					default:
						validEquation = false;
						break;
				}

				if (validEquation)
					stringAnswer = System.Convert.ToString (numericAnswer);
			}
			
			return (stringAnswer);
		}

		//
		// Resets the various module-level variables for the next calculation.
		//

		public static void CalcReset ()
		{
			numericAnswer = 0;
			firstNumber = 0;
			secondNumber = 0;
			stringAnswer = "";
			calcOperation = Operator.eUnknown;
			decimalAdded = false;
			secondNumberAdded = false;			
		}

	}
}