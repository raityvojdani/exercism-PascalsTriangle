using System;
using System.Collections.Generic;
/// <summary>
/// This class provides a method to calculate Pascal's Triangle up to a specified number of rows.
/// </summary>
public class PascalsTriangle
{

    public PascalsTriangle(){}

    public IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        return GeneratePascalsTriangle(rows);
    }

    private List<List<int>> GeneratePascalsTriangle(int rows)
    {
        List<List<int>> result = new List<List<int>>();

        for (int i = 0; i < rows; i++)
        {
            List<int> row = new List<int>();
            row.Add(1);

            for (int j = 1; j < i; j++)
            {
                int previousRowLeft = result[i - 1][j - 1];
                int previousRowRight = result[i - 1][j];
                row.Add(previousRowLeft + previousRowRight);
            }

            if (i > 0)
            {
                row.Add(1);
            }

            result.Add(row);
        }

        return result;
    }

}
