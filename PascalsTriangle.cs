using System;
using System.Collections.Generic;

public static  class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        // A list to hold all rows of List<List<int>> type 
        List<List<int>> result = new List<List<int>>();

        // Loops to generate rows
        for (int i = 0; i < rows; i++)
        {
            // Each line is a new list
            List<int> row = new List<int>();

            // The first number of each row is always 1
            row.Add(1);

            // If the row has more than 2 elements, the middle elements should be calculated
            for (int j = 1; j < i; j++)
            {
                int previousRowLeft = result[i - 1][j - 1];
                int previousRowRight = result[i - 1][j];
                row.Add(previousRowLeft + previousRowRight);
            }

            //The last number of each line is always 1 (except the first line).
            if (i > 0)
            {
                row.Add(1);
            }

            //Add row to the main list
            result.Add(row);
        }

        return result;
    }
}
