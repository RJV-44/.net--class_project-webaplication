using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24SOECE11019_RAJVI_LUNAGARIYA_TUTORIAL_2
{
    internal class EXAMPLE10
    {
        static void Main()
        {
            Console.Write("Enter number of rows (N): ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of columns (M): ");
            int M = Convert.ToInt32(Console.ReadLine());

            int[,] mat = new int[N, M];

            Console.WriteLine("Enter matrix elements:");

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    mat[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("Enter element to search (X): ");
            int X = Convert.ToInt32(Console.ReadLine());

            int row = 0;
            int col = M - 1;
            int found = 0;

            while (row < N && col >= 0)
            {
                if (mat[row, col] == X)
                {
                    found = 1;
                    break;
                }
                else if (mat[row, col] > X)
                {
                    col--;
                }
                else
                {
                    row++;
                }
            }

            Console.WriteLine("Output: " + found);
        }

    }
}
