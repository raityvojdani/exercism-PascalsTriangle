namespace ConsoleApp1;

internal class Program
{
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    /// <param name="args">The command-line arguments.</param>
    static void Main(string[] args)
    {
        // Use dependency injection to create an instance of the PascalsTriangle class.
        PascalsTriangle pascalsTriangle = new PascalsTriangle();

        // Calculate Pascal's Triangle up to 7 rows.
        IEnumerable<IEnumerable<int>> result = pascalsTriangle.Calculate(7);

        // Iterate through the result and print each row.
        foreach (IEnumerable<int> row in result)
        {
            foreach (int num in row)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(); // Create a new line after each row.
        }
    }
}
