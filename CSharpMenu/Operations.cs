using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpMenu
{
	public class Operations
	{
		SleepAndClear sleepAndClear = new SleepAndClear();
		public int menuOperation { get; set; }
		public int calculatorOperation { get; set; }
		public int ageCalculatorOperation { get; set; }
		public int evenOrOddOperation { get; set; }
		public int monthOperation { get; set; }
		public int factorialOperation { get; set; }
		public int averageOperation { get; set; }
		public int squareOperation { get; set; }
		public int squareRootOperation { get; set; }
		public int exponentialCalculation { get; set; }
		public void Login()
		{
			SignIn signIn = new SignIn();

			while (true)
			{
				Console.Write("Please enter username : ");
				signIn.username = Console.ReadLine();
				Console.Write("Please enter password : ");
				signIn.password = Console.ReadLine();

				if (signIn.sys_username == signIn.username && signIn.sys_password == signIn.password)
				{
					Console.WriteLine("Welcome {0};", signIn.sys_username);
					sleepAndClear.ForSigIn();
					break;
				}
				else
				{
					Console.WriteLine("Invalid username or password!!!");
					sleepAndClear.ForSigIn();
					continue;
				}
			}
		}
		public void Addition()
		{
			ConsoleKeyInfo k;
			List<double> addition = new List<double>();
			while (true)
			{
				addition.Add(double.Parse(Console.ReadLine()));
				k = Console.ReadKey(true);
				if (k.Key == ConsoleKey.Enter)
					break;
			}
			Console.WriteLine("Result = {0}", addition.Sum());
			Console.ReadLine();
		}
		public void Substraction()
		{
			ConsoleKeyInfo k;
			double result = 0;
			List<double> substraction = new List<double>();
			while (true)
			{
				substraction.Add(double.Parse(Console.ReadLine()));
				k = Console.ReadKey(true);
				if (k.Key == ConsoleKey.Enter)
					break;
			}
			for (int i = 1; i < substraction.Count; i++)
			{
				result -= substraction[i];
			}
			result += substraction[0];
			Console.WriteLine("Result = {0}", result);
			Console.ReadLine();
		}
		public void Multiplication()
		{
			ConsoleKeyInfo k;
			double result = 1;
			List<double> multiplication = new List<double>();
			while (true)
			{
				multiplication.Add(double.Parse(Console.ReadLine()));
				k = Console.ReadKey(true);
				if (k.Key == ConsoleKey.Enter)
					break;
			}
			for (int i = 0; i < multiplication.Count; i++)
			{
				result *= multiplication[i];
			}
			Console.WriteLine("Result = {0}", result);
			Console.ReadLine();
		}
		public void Division()
		{
			ConsoleKeyInfo k;
			double result = 0;
			List<double> division = new List<double>();
			while (true)
			{
				division.Add(double.Parse(Console.ReadLine()));
				k = Console.ReadKey(true);
				if (k.Key == ConsoleKey.Enter)
					break;
			}
			double x = division[0];
			for (int i = 1; i < division.Count; i++)
			{
				x /= division[i];
			}
			result = x;
			Console.WriteLine("Result = {0}", result);
			Console.ReadLine();
		}
		public void AgeCalculation()
		{
			TimeSpan difference;
			int age;
			DateTime birthdayDate;
			Console.Write("Please enter your birthday date : ");
			birthdayDate = Convert.ToDateTime(Console.ReadLine());
			difference = DateTime.Now.Date.Subtract(birthdayDate);
			age = Convert.ToInt32(difference.TotalDays);
			Console.WriteLine("You are {0} years old.", age / 365);
			Console.ReadLine();
		}
		public void EvenOrOdd()
		{
			Console.Write("Please enter a number : ");
			var number = int.Parse(Console.ReadLine());
			if (number % 2 == 0)
			{
				Console.WriteLine("{0} is even", number);
			}
			else
			{
				Console.WriteLine("{0} is odd", number);
			}
			Console.ReadLine();
		}
		public void Months()
		{
			Console.Write("Please enter the Month number : ");
			int x = int.Parse(Console.ReadLine());
			switch (x)
			{
				case 1: Console.WriteLine("January"); break;
				case 2: Console.WriteLine("February"); break;
				case 3: Console.WriteLine("March"); break;
				case 4: Console.WriteLine("April"); break;
				case 5: Console.WriteLine("May"); break;
				case 6: Console.WriteLine("June"); break;
				case 7: Console.WriteLine("July"); break;
				case 8: Console.WriteLine("August"); break;
				case 9: Console.WriteLine("September"); break;
				case 10: Console.WriteLine("October"); break;
				case 11: Console.WriteLine("November"); break;
				case 12: Console.WriteLine("December"); break;
				default: Console.WriteLine("!!!Invalid Month Number!!!"); break;
			}
			switch (x)
			{
				case 1:
				case 2:
				case 3:
				case 4:
				case 5:
				case 6: Console.WriteLine("First Half of The Year"); break;
				case 7:
				case 8:
				case 9:
				case 10:
				case 11:
				case 12: Console.WriteLine("Second Half of The Year"); break;
			}
			switch (x)
			{
				case 9:
				case 10:
				case 11: Console.WriteLine("Autumn"); break;
				case 12:
				case 1:
				case 2: Console.WriteLine("Winter"); break;
				case 3:
				case 4:
				case 5: Console.WriteLine("Spring"); break;
				case 6:
				case 7:
				case 8: Console.WriteLine("Summer"); break;
			}
			Console.ReadLine();
		}
		public void FactorialCalculation()
		{
			Console.Write("Please enter a number : ");
			int x = int.Parse(Console.ReadLine());
			int factorial = 1;
			for (int i = 0; i < x; x--)
			{
				factorial = factorial * x;
			}
			Console.WriteLine("Result = {0}", factorial);
			Console.ReadLine();
		}
		public void AverageCalculation()
		{
			ConsoleKeyInfo k;
			List<double> numbers = new List<double>();
			Console.WriteLine("Please enter numbers (Press ENTER to exit): ");
			while (true)
			{
				numbers.Add(double.Parse(Console.ReadLine()));
				k = Console.ReadKey(true);
				if (k.Key == ConsoleKey.Enter)
					break;
			}
			Console.Write("Your numbers are ");
			foreach (var item in numbers)
			{
				Console.Write(item);
				Console.Write(" ");
			}
			Console.WriteLine();
			Console.WriteLine("Average = {0}", numbers.Average());
			Console.ReadLine();
		}
		public void SquareCalculation()
		{
			Console.Write("Please enter a number : ");
			double x = double.Parse(Console.ReadLine());
			Console.WriteLine("Result = {0}", Math.Pow(x, 2));
			Console.ReadLine();
		}
		public void SquareRootCalculation()
		{
			Console.Write("Please enter a number : ");
			double x = double.Parse(Console.ReadLine());
			Console.WriteLine("Result = {0}", Math.Sqrt(x));
			Console.ReadLine();
		}
		public void ExponentialCalculation()
		{
			Console.Write("Please enter a number : ");
			double number = double.Parse(Console.ReadLine());
			Console.Write("Please enter a power : ");
			int power = int.Parse(Console.ReadLine());
			Console.WriteLine("Result = {0}", Math.Pow(number, power));
			Console.ReadLine();
		}
	}
}
