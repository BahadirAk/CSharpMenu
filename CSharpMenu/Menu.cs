using System;

namespace CSharpMenu
{
	public class Menu
	{
		Operations operations = new Operations();
		SleepAndClear sleepAndClear = new SleepAndClear();
		ConsoleOperations consoleOperations = new ConsoleOperations();
		public void GetMenu()
		{
			while (true)
			{
				Menu:
				sleepAndClear.Clear();
				consoleOperations.Menu();
				operations.menuOperation = int.Parse(Console.ReadLine());

				switch (operations.menuOperation)
				{
					case 1:
						while (true)
						{
							sleepAndClear.Clear();
							consoleOperations.Calculator();
							operations.calculatorOperation = int.Parse(Console.ReadLine());

							switch (operations.calculatorOperation)
							{
								case 1:
									sleepAndClear.Clear();
									Console.WriteLine("Please enter the numbers that you want to sum (Press ENTER to exit): ");
									operations.Addition();
									break;
								case 2:
									sleepAndClear.Clear();
									Console.WriteLine("Please enter the numbers that you want to substract (Press ENTER to exit): ");
									operations.Substraction();
									break;
								case 3:
									sleepAndClear.Clear();
									Console.WriteLine("Please enter the numbers that you want to multiply (Press ENTER to exit): ");
									operations.Multiplication();
									break;
								case 4:
									sleepAndClear.Clear();
									Console.WriteLine("Please enter the numbers that you want to divide (Press ENTER to exit): ");
									operations.Division();
									break;
								case 5:
									goto Menu;
								default:
									Console.WriteLine("!!Invalid Operation!!");
									break;
							}
						}
					case 2:
						while (true)
						{
							sleepAndClear.Clear();
							consoleOperations.AgeCalculation();
							operations.ageCalculatorOperation = int.Parse(Console.ReadLine());

							switch (operations.ageCalculatorOperation)
							{
								case 1:
									sleepAndClear.Clear();
									operations.AgeCalculation();
									break;
								case 2:
									goto Menu;
								default:
									Console.WriteLine("!!Invalid Operation!!");
									break;
							}
						}
					case 3:
						while (true)
						{
							sleepAndClear.Clear();
							consoleOperations.EvenOrOdd();
							operations.evenOrOddOperation = int.Parse(Console.ReadLine());

							switch (operations.evenOrOddOperation)
							{
								case 1:
									sleepAndClear.Clear();
									operations.EvenOrOdd();
									break;
								case 2:
									goto Menu;
								default:
									Console.WriteLine("!!Invalid Operation!!");
									break;
							}
						}
					case 4:
						while (true)
						{
							sleepAndClear.Clear();
							consoleOperations.Months();
							operations.monthOperation = int.Parse(Console.ReadLine());

							switch (operations.monthOperation)
							{
								case 1:
									sleepAndClear.Clear();
									operations.Months();
									break;
								case 2:
									goto Menu;
								default:
									Console.WriteLine("!!Invalid Operation!!");
									break;
							}
						}
					case 5:
						while (true)
						{
							sleepAndClear.Clear();
							consoleOperations.FactorialCalculation();
							operations.factorialOperation = int.Parse(Console.ReadLine());

							switch (operations.factorialOperation)
							{
								case 1:
									sleepAndClear.Clear();
									operations.FactorialCalculation();
									break;
								case 2:
									goto Menu;
								default:
									Console.WriteLine("!!Invalid Operation!!");
									break;
							}
						}
					case 6:
						while (true)
						{
							sleepAndClear.Clear();
							consoleOperations.AverageCalculation();
							operations.averageOperation = int.Parse(Console.ReadLine());

							switch (operations.averageOperation)
							{
								case 1:
									sleepAndClear.Clear();
									operations.AverageCalculation();
									break;
								case 2:
									goto Menu;
								default:
									Console.WriteLine("!!Invalid Operation!!");
									break;
							}
						}
					case 7:
						while (true)
						{
							sleepAndClear.Clear();
							consoleOperations.SquareCalculation();
							operations.squareOperation = int.Parse(Console.ReadLine());

							switch (operations.squareOperation)
							{
								case 1:
									sleepAndClear.Clear();
									operations.SquareCalculation();
									break;
								case 2:
									goto Menu;
								default:
									Console.WriteLine("!!Invalid Operation!!");
									break;
							}
						}
					case 8:
						while (true)
						{
							sleepAndClear.Clear();
							consoleOperations.SquareRootCalculation();
							operations.squareRootOperation = int.Parse(Console.ReadLine());

							switch (operations.squareRootOperation)
							{
								case 1:
									sleepAndClear.Clear();
									operations.SquareRootCalculation();
									break;
								case 2:
									goto Menu;
								default:
									Console.WriteLine("!!Invalid Operation!!");
									break;
							}
						}
					case 9:
						while (true)
						{
							sleepAndClear.Clear();
							consoleOperations.ExponentialCalculation();
							operations.exponentialCalculation = int.Parse(Console.ReadLine());

							switch (operations.exponentialCalculation)
							{
								case 1:
									sleepAndClear.Clear();
									operations.ExponentialCalculation();
									break;
								case 2:
									goto Menu;
								default:
									Console.WriteLine("!!Invalid Operation!!");
									break;
							}
						}
					case 10:
						goto End;
					default:
						Console.WriteLine("!!Invalid Operation!!");
						break;
				}
			}
			End:
			Console.ReadLine();
		}
	}
}
