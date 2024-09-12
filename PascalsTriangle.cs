using System;
using System.Collections.Generic;

/// <summary>
/// Represents a class for calculating Pascal's Triangle.
/// </summary>
public class PascalsTriangle
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PascalsTriangle"/> class.
    /// </summary>
    public PascalsTriangle()
    {
    }

    /// <summary>
    /// Calculates Pascal's Triangle up to the specified number of rows.
    /// </summary>
    /// <param name="rows">The number of rows to calculate.</param>
    /// <returns>A collection of collections representing Pascal's Triangle.</returns>
    public IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        return GeneratePascalsTriangle(rows);
    }

    /// <summary>
    /// Generates Pascal's Triangle up to the specified number of rows.
    /// </summary>
    /// <param name="rows">The number of rows to generate.</param>
    /// <returns>A collection of collections representing Pascal's Triangle.</returns>
    private IEnumerable<IEnumerable<int>> GeneratePascalsTriangle(int rows)
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
