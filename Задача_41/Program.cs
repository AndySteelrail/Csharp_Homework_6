using System;
					
public class Program
{
	public static void Main()
	{
		double[] InputNumbers()
        {
            Console.WriteLine("Введите числа через запятую");
            string input = String.Empty + Console.ReadLine();
            string[] inputs = input.Split(',');
            double[] inputNumbers = new double[inputs.Length];
            for (int i=0; i<inputs.Length; i++)
                {inputNumbers[i] = Double.Parse(inputs[i]);}

            return inputNumbers[];
        }



	}
}