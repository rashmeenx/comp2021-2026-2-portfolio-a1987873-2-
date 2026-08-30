namespace BrokenProgram
{
    public static class Program
    {
        private static void Main()
        {
            const string input = """
            23
            +
            77
            +
            3
            +
            457
            *
            2
            """;
            int total = 0;
            List<int> items = [];
            List<string> symbols = [];

            string[] lines = input.Split(
                '\n',
                StringSplitOptions.RemoveEmptyEntries
            );

            for (int i = 0; i < lines.Length; i += 2)
            {
                items.Add(int.Parse(lines[i].Trim(), System.Globalization.CultureInfo.InvariantCulture));
                if (i != 0)
                {
                    symbols.Add(lines[i - 1].Trim());
                }
            }


            foreach ((int i, int value) in items.Index())
            {
                if (i == 0) { total = value; }
                else if (symbols[i - 1] == "*")
                {
                    total *= value;
                }
                else
                {
                    total += value;
                }
            }
            Console.WriteLine("Total was: " + total);
            Console.WriteLine("Expected total was: 1120");
            Console.WriteLine(total == 1120 ? "Your answer was RIGHT!" : "Your answer was WRONG!\nGo and fix it.");
        }
    }
}

