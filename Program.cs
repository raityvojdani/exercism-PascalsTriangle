namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {

        // Create an instance of PascalsTriangle via dependency injection
        PascalsTriangle triangle = new PascalsTriangle();

        IEnumerable<IEnumerable<int>> result = triangle.Calculate(7);

        //You must use foreach to access the result values ​​because result is an IEnumerable.
        foreach (IEnumerable<int> row in result)
        {
            
            foreach (int num in row)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine(); //To create a new line after each row
        }

    }
}
