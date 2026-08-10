List<string> tasks = new List<string>();

Dictionary<string, List<int>> tags =
    new Dictionary<string, List<int>>();

while (true)
{
    Console.Write("Enter command: ");
    string input = Console.ReadLine() ?? "";

    string[] parts = input.Split(' ', 3);
    string command = parts[0].ToLower();

    try
    {
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
                tags.Clear();
                Console.WriteLine("All tasks cleared.");
                break;

            case "tag":
                if (parts.Length < 3)
                {
                    Console.WriteLine("Use: tag [index] [name]");
                    break;
                }

                if (!int.TryParse(parts[1], out int tagIndex))
                {
                    Console.WriteLine("Please enter a valid number.");
                    break;
                }

                if (tagIndex < 0 || tagIndex >= tasks.Count)
                {
                    throw new IndexOutOfRangeException(
                        "That task index does not exist."
                    );
                }

                string tagName = parts[2];

                if (!tags.ContainsKey(tagName))
                {
                    tags[tagName] = new List<int>();
                }

                if (tags[tagName].Contains(tagIndex))
                {
                    throw new ArgumentException(
                        "That task already has this tag."
                    );
                }

                tags[tagName].Add(tagIndex);

                Console.WriteLine(
                    $"Tagged task {tagIndex} as '{tagName}'."
                );
                break;

            case "get-tagged":
                if (parts.Length < 2)
                {
                    Console.WriteLine("Use: get-tagged [tag]");
                    break;
                }

                string requestedTag = parts[1];

                if (!tags.ContainsKey(requestedTag))
                {
                    throw new KeyNotFoundException(
                        "That tag does not exist."
                    );
                }

                Console.WriteLine(
                    $"Tasks tagged '{requestedTag}':"
                );

                foreach (int taggedIndex in tags[requestedTag])
                {
                    Console.WriteLine(
                        $"{taggedIndex}: {tasks[taggedIndex]}"
                    );
                }
                break;

            case "exit":
                Console.WriteLine("Goodbye.");
                return;

            default:
                Console.WriteLine(
                    "Invalid command. Use add, show, remove, clear, tag, get-tagged, or exit."
                );
                break;
        }
    }
    catch (IndexOutOfRangeException exception)
    {
        Console.WriteLine(exception.Message);
    }
    catch (ArgumentException exception)
    {
        Console.WriteLine(exception.Message);
    }
    catch (KeyNotFoundException exception)
    {
        Console.WriteLine(exception.Message);
    }
}