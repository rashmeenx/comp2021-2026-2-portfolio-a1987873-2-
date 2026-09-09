using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public static void Main()
    {
        List<string> names = new List<string>()
        {
            "Rashmeen",
            "Aisha",
            "Zara",
            "Nadia",
            "Maya",
            "Sofia",
            "Emma",
            "Lina",
            "Hannah",
            "Olivia"
        };

        var orderedNames = names.OrderBy(x => x);

        List<string> sortedNames = orderedNames.ToList();

        foreach (string name in sortedNames)
        {
            Console.WriteLine(name);
        }
    }
}