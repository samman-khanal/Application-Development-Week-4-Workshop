using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a day: ");
        string inputDay = Console.ReadLine().Trim().ToLower();

        DayType dayType;

        if (inputDay == "friday" || inputDay == "saturday")
        {
            dayType = DayType.Weekend;
            Console.WriteLine("It is: Weekwnd");
        }
        else
        {
            dayType = DayType.Weekday;
            Console.WriteLine("It is: Weekday");
        }

        //? Creating the object for book.
        Book book1 = new Book("It ends with us", "Colleen Hoover", 499.90);

        //? Using with and changing the title and the price.
        Book book2 = book1 with { title = "It starts with us", price = 599.90 };

        //? Printing the book1 object.
        Console.WriteLine(book1);

        //? Deconstructing the book2 with three variables.
        var (title, author, price) = book2;
        Console.WriteLine($"Title: {title}, Author: {author}, Price: {price}");
    }
}