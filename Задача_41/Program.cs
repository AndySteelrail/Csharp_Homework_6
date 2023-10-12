// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using System;
					
public class Program
{
	public static void Main()
	{
		double[] InputNumbers()
        {
            Console.WriteLine("Введите числа через точку с запятой");
            string input = Console.ReadLine()??"";
            string[] inputs = input.Split(';');
            double[] inputNumbers = new double[inputs.Length];
            for (int i=0; i<inputs.Length; i++)
                {inputNumbers[i] = Double.Parse(inputs[i]);}

            return inputNumbers;
        }

        int CountPositiveNumbers(double[] array)
        {
            int sumOfPositiveNumbers = 0;
            for (int i = 0; i<array.Length; i++)
                {if (array[i] > 0) sumOfPositiveNumbers++;}
            return sumOfPositiveNumbers;
        }

        void OutputMessage(int sumOfPositiveNumbers)
        {
            Console.WriteLine(
                "В веденном массиве " + 
                sumOfPositiveNumbers +
                " положительных чисел");
        }

        double[] inputNumbers = InputNumbers();
        int sumOfPositiveNumbers = CountPositiveNumbers(inputNumbers);
        OutputMessage(sumOfPositiveNumbers);
	}
}