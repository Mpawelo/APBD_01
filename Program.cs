Console.WriteLine("Modyfikacja 1");
Console.WriteLine("Modyfikacja 2");
Console.WriteLine("Modyfikacja 3");

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Średnia: {CalculateAverage(numbers)}");
    }

    public static double CalculateAverage(int[] numbers)
{
    int sum = 0;
    foreach (var num in numbers) // Zmiana np. num -> value
    {

        sum += num;
 feature-new
    }
    return (double)sum / numbers.Length;
}

}

using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine($"Maksymalna wartość: {FindMax(numbers)}");
    }

    static int FindMax(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
            throw new ArgumentException("Tablica nie może być pusta");

        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
                max = num;
        }
        return max;
    }
}

