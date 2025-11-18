using System;

public class Program
{
    public static void Main(string[] args)
    {
        ParameterDemo demo = new ParameterDemo();

        int value = 5;
        Console.WriteLine("Original Number: " + value);

        demo.Increase(ref value);
        Console.WriteLine("Increased Number: " + value);

        demo.DisplayMessage(out string fullname);
        Console.WriteLine("Returned Full Name: " + fullname);

        int sum = demo.SumAll(1, 2, 3, 4, 5);
        Console.WriteLine("Sum of the elements of array: " + sum);

    }
}