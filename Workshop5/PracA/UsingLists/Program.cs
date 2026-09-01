using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<string> students = ["Rashmeen", "Mango", "Apple", "Orange"];

        students.Add("Strawberry");
        students.Remove("Rashmeen");
        students.Insert(1, "Emma");

        students.AddRange(new List<string>
                {
                    "Frank",
                    "Grace",
                    "Henry",
                    "Isabella",
                    "Jack",
                    "Charlotte"
                });

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }

        string searchName = "Grace";

        int index = students.IndexOf(searchName);

        Console.WriteLine($"\nIndex of {searchName}: {index}");

        string partialName = "a";

        Console.WriteLine($"\nNames containing '{partialName}':");

        foreach (string student in students)
        {
            if (student.Contains(partialName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine(student);
            }
        }

        // Sum of the length of all names
        int totalLength = 0;

        foreach (string student in students)
        {
            totalLength += student.Length;
        }

        Console.WriteLine($"\nTotal length of all names: {totalLength}");

        // Array from Task 1
        string[] names =
        {
                    "Zara",
                    "Ben",
                    "Emily",
                    "Alice",
                    "Christopher",
                    "Dana",
                    "Jack",
                    "Gabriella",
                    "Frank",
                    "Henry"
        };

        // Convert the array into a List
        List<string> namesFromArray = new List<string>(names);

        // Add those values to the Task 2 List
        students.AddRange(namesFromArray);

        Console.WriteLine("\nStudent list after adding Task 1 array:");

        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
}
