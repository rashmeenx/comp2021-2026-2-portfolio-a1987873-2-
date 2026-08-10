List<string> tasks = new List<string>();

while (true)
{
    Console.Write("Enter command: ");
    string input = Console.ReadLine() ?? "";

    string[] parts = input.Split(' ', 2);
    string command = parts[0].ToLower();

    switch (command)
    {
        case "add":
            if (parts.Length < 2 || string.IsNullOrWhiteSpace(parts[1]))
            {
                Console.WriteLine("Please enter a task to add.");
            }
            else
            {
                tasks.Add(parts[1]);
                Console.WriteLine("Task added.");
            }
            break;

        case "show":
            if (tasks.Count == 0)
            {
                Console.WriteLine("No tasks found.");
            }
            else
            {
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i}: {tasks[i]}");
                }
            }
            break;

        case "remove":
            if (parts.Length < 2)
            {
                Console.WriteLine("Please enter the index of the task to remove.");
            }
            else if (!int.TryParse(parts[1], out int index))
            {
                Console.WriteLine("Please enter a valid number.");
            }
            else if (index < 0 || index >= tasks.Count)
            {
                Console.WriteLine("That task index does not exist.");
            }
            else
            {
                Console.WriteLine($"Removed: {tasks[index]}");
                tasks.RemoveAt(index);
            }
            break;

        case "clear":
            tasks.Clear();
            Console.WriteLine("All tasks cleared.");
            break;

        case "exit":
            Console.WriteLine("Goodbye.");
            return;

        default:
            Console.WriteLine("Invalid command. Use add, show, remove, clear, or exit.");
            break;
    }
}