using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Pide 5 calificaciones y las guarda en una lista
        List<double> grades = Enumerable
            .Range(1, 5)
            .Select(ReadGrade)
            .ToList();

        // Funciones de agregación de LINQ: se declara QUÉ se quiere, no CÓMO calcularlo
        double max = grades.Max();
        double min = grades.Min();
        double average = grades.Average();

        Console.WriteLine("\n--- Student Information ---");
        Console.WriteLine($"Grades:  {string.Join(", ", grades)}");
        Console.WriteLine($"Maximum: {max}");
        Console.WriteLine($"Minimum: {min}");
        Console.WriteLine($"Average: {average:F2}");
    }

    // Lee una calificación; si la entrada no es válida, vuelve a pedirla
    static double ReadGrade(int number)
    {
        Console.Write($"Enter grade #{number}: ");

        return double.TryParse(Console.ReadLine(), out double grade)
            ? grade
            : InvalidAndRetry(number);
    }

    static double InvalidAndRetry(int number)
    {
        Console.WriteLine("Invalid number, try again.");
        return ReadGrade(number);
    }
}