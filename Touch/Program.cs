if (args.Length == 0)
{
    Console.WriteLine("Usage: touch <filename>");
    return;
}
string fileName = args[0];
string filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);

try
{
    if (!File.Exists(filePath))
    {
        File.Create(filePath).Dispose();
    }
    else
    {
        Console.WriteLine($"File already exists: {filePath}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}
