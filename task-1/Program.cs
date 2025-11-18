using System;
public class Program
{
    public static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.Name = "Nischal Shrestha";
        student1.RollNumber = 101;
        student1.Section = "L3C8";

        Student student2 = new Student();
        student2.Name = "Prince Shrestha";
        student2.RollNumber = 102;
        student2.Section = "L3C8";

        //? Printing the instakce fields
        
        //? Printing the details of student1
        Console.WriteLine("Student 1 Details:");
        Console.WriteLine("Name: " + student1.Name);
        Console.WriteLine("Roll Number: " + student1.RollNumber);
        Console.WriteLine("Section: " + student1.Section);

        //? Printing the details of student2
        Console.WriteLine("\nStudent 2 Details:");
        Console.WriteLine("Name: " + student2.Name);
        Console.WriteLine("Roll Number: " + student2.RollNumber);
        Console.WriteLine("Section: " + student2.Section);

        //? Printing the static fields
        Console.WriteLine("College Name: " + Student.CollegeName);
    }
}
