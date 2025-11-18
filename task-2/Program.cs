using System;

public class Program
{
    public static void Main(string[] args)
    {
        Calculator calculator = new Calculator();

        calculator.PrintWelcome();

        int add = calculator.Add(5, 10);
        Console.WriteLine("The sum is: " + add);
        int mul = calculator.Multiply(5);
        Console.WriteLine("The product is: " + mul);


    }
}
