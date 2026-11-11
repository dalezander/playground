internal class Program
{
    /// <summary>
    /// Entry point of the application that reads user input and computes its MD5 hash with optional salt.
    /// </summary>
    /// <param name="args">Command-line arguments (not used in this application).</param>
    /// <remarks>
    /// This method prompts the user to enter text and an optional salt value, then computes and displays
    /// the MD5 hash of the combined input. If no input is provided, a message is displayed and the method returns.
    /// The hash computation is delegated to the <see cref="Utils.ComputeHash"/> method.
    /// </remarks>
    private static void Main(string[] args)
    {
        Console.WriteLine(string.Join(" ", args));

        Console.Write("Enter text to hash: ");
        string? input = Console.ReadLine();

        Console.Write("Enter salt value: ");
        string? salt = Console.ReadLine();

        if (input is null)
        {
            Console.WriteLine("No input provided.");
            return;
        }

        string hash = Utils.ComputeHash(input, salt);
        Console.WriteLine($"Hash: {hash}");
    }
}