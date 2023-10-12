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