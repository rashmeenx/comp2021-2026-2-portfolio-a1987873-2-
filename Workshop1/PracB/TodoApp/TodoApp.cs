List<string> tasks = new List<string>();

Dictionary<string, List<int>> tags =
    new Dictionary<string, List<int>>();

while (true)
{
    Console.Write("Enter command: ");
    string input = Console.ReadLine() ?? "";

    string[] parts = input.Split(' ', 2);
    string command = parts[0].ToLower();

    try
    {
        switch (command)
        {
            case "add":
                AddTask(parts, tasks);
                break;

            case "show":
                ShowTasks(tasks);
                break;

            case "remove":
                RemoveTask(parts, tasks);
                break;

            case "clear":
                ClearTasks(tasks, tags);
                break;

            case "tag":
                TagTask(parts, tasks, tags);
                break;

            case "get-tagged":
                ShowTaggedTasks(tasks, tags);
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

static void AddTask(string[] parts, List<string> tasks)
{
    if (parts.Length < 2 || string.IsNullOrWhiteSpace(parts[1]))
    {
        Console.WriteLine("Please enter a task to add.");
        return;
    }

    tasks.Add(parts[1]);
    Console.WriteLine("Task added.");
}

static void ShowTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("No tasks found.");
        return;
    }

    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i}: {tasks[i]}");
    }
}

static void RemoveTask(string[] parts, List<string> tasks)
{
    if (parts.Length < 2)
    {
        Console.WriteLine("Please enter the index of the task to remove.");
        return;
    }

    if (!int.TryParse(parts[1], out int index))
    {
        Console.WriteLine("Please enter a valid number.");
        return;
    }

    if (index < 0 || index >= tasks.Count)
    {
        throw new IndexOutOfRangeException(
            "That task index does not exist."
        );
    }

    Console.WriteLine($"Removed: {tasks[index]}");
    tasks.RemoveAt(index);
}

static void ClearTasks(
    List<string> tasks,
    Dictionary<string, List<int>> tags)
{
    tasks.Clear();
    tags.Clear();

    Console.WriteLine("All tasks cleared.");
}

static void TagTask(
    string[] parts,
    List<string> tasks,
    Dictionary<string, List<int>> tags)
{
    if (parts.Length < 2)
    {
        Console.WriteLine("Use: tag [index]");
        return;
    }

    if (!int.TryParse(parts[1], out int tagIndex))
    {
        Console.WriteLine("Please enter a valid number.");
        return;
    }

    if (tagIndex < 0 || tagIndex >= tasks.Count)
    {
        throw new IndexOutOfRangeException(
            "That task index does not exist."
        );
    }

    string tagName = "tagged";

    if (!tags.ContainsKey(tagName))
    {
        tags[tagName] = new List<int>();
    }

    if (tags[tagName].Contains(tagIndex))
    {
        throw new ArgumentException(
            "That task is already tagged."
        );
    }

    tags[tagName].Add(tagIndex);

    Console.WriteLine($"Tagged task {tagIndex}.");
}

static void ShowTaggedTasks(
    List<string> tasks,
    Dictionary<string, List<int>> tags)
{
    string tagName = "tagged";

    if (!tags.ContainsKey(tagName))
    {
        throw new KeyNotFoundException(
            "No tagged tasks exist."
        );
    }

    Console.WriteLine("Tagged tasks:");

    foreach (int taggedIndex in tags[tagName])
    {
        Console.WriteLine($"{taggedIndex}: {tasks[taggedIndex]}");
    }
}