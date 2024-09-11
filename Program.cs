namespace ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {

        //There is no need to create an object from PascalsTriangle, because the class and method are static.
        IEnumerable<IEnumerable<int>> result = PascalsTriangle.Calculate(3);

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
