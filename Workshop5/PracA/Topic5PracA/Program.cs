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

Console.WriteLine("Main string: ");

foreach (string name in names)
{
    Console.WriteLine(name);
}

string LongestName = names[0];

foreach (string name in names)
{
    if (name.Length > LongestName.Length)
    {
        LongestName = name;
    }
}

Console.WriteLine($"Longest name: {LongestName}");

string ShortestName = names[0];

foreach (string name in names)
{
    if (name.Length < ShortestName.Length)
    {
        ShortestName = name;
    }
}

Console.WriteLine($"Shortest name: {ShortestName}");


Console.WriteLine("\nBefore sorting:");
foreach (string name in names)
{
    Console.WriteLine(name);
}

Array.Sort(names);

Console.WriteLine("\nAfter sorting:");
foreach (string name in names)
{
    Console.WriteLine(name);
}

Console.WriteLine("\nBefore Reversing:");
foreach (string name in names)
{
    Console.WriteLine(name);
}

Array.Reverse(names);

Console.WriteLine("\nAfter Reversing:");
foreach (string name in names)
{
    Console.WriteLine(name);
}