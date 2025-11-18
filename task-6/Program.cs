using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the marks: ");
        string marksValue = Console.ReadLine();

        Console.Write("Enter the total marks: ");
        string totalValue = Console.ReadLine();

        int marks, total;

        //? Using TryParse to convert string value to integer value.
        if(!int.TryParse(marksValue, out marks))
        {
            Console.WriteLine("Invalid input for marks.");
            return;
        }
        if(!int.TryParse(totalValue, out total))
        {
            Console.WriteLine("Invalid input for total marks.");
            return;
        }

        //! The calculation below is the first breaking point for debugging. 

        //* Why is the output incorrect? 
        //? There is a slight logical error here. The marks and total are the integers. And the percentage is in double.
        //? So the program performs an integer division. 
        //? So for example, ig the marks iss 45 and the total is 100, the integer division will give the result of 0 instead of 0.45.
        //? This program will execute but the expected output will not be seen. 

        //* How can we correct the program?
        //? To fix this logical error, we can cast the marks or total, any one as double.
        //? So if any one of the variable is double, the calculation will also be done in double and the program is executed as expected.

        //* Correct solution to the problem.
        //! double percentage = (double)marks / total * 100;

        // * Calculation
        double percentage = marks / total * 100;
        
        Console.WriteLine($"The percentage is: {percentage}%");
    }
}
