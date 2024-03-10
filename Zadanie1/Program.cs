namespace Zadanie1;

public class main
{
    public static void Main(string[] args)
    {
        int[] exampleArray = { 1, 3, 5, 7, 9 };
        double average = CalculateAverage(exampleArray);
        Console.WriteLine($"Średnia wartość to: {average}");
    }
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Tablica nie może być pusta");
        }

        double sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum / numbers.Length;
    }
}
