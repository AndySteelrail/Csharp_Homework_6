// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

using System;
                    
public class Program
{
    public static void Main()
    {
        double GetInput(string messageHello, string messageBye)
        {
            Console.WriteLine(messageHello);
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine($"{messageBye}: {number}");
            
            return number;
        }
            
        string FindCrossing(double b1, double k1, double b2, double k2)
        {
            double x = Math.Round( (b2 - b1) / (k1 - k2), 2);
            double y = Math.Round( (b1 * k2 - b2 * k1) / (k1 - k2), 2);
            
            string coordinate = "("+ x + ", " + y + ")";
            return coordinate;
        }
        
        double b1 = GetInput("Введите параметр b для 1й прямой", "b1");
        double k1 = GetInput("Введите параметр k для 1й прямой", "k1");
        double b2 = GetInput("Введите параметр b для 2й прямой", "b2");
        double k2 = GetInput("Введите параметр k для 2й прямой", "k2");
        Console.WriteLine($"Пересечение находится в точке с координатами (x, y): {FindCrossing(b1, k1, b2, k2)}");
        
    }
}