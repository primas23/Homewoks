using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.EightQueensPuzzle
{
    public class Startup
    {
        public static int Queens(int n, bool[,] table)
        {
            if (n == 0)
            {
                return 1;
            }

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    bool canPlaceQueen = true;
                    // check row
                    for (int k = 0; k < table.GetLength(1); k++)
                    {
                        if (table[i, k])
                        {
                            canPlaceQueen = false;
                            break;
                        }
                    }

                    // check column
                    for (int k = 0; k < table.GetLength(0); k++)
                    {
                        if (table[j, k])
                        {
                            canPlaceQueen = false;
                            break;
                        }
                    }

                    int[] dx = { 1, -1, 0, 0, 1, 1, -1, -1 };
                    int[] dy = { 0, 0, 1, -1, -1, 1, -1, 1 };

                    for (int di = 0; di < dx.Length; di++)
                    {
                        int x = i;
                        int y = j;

                        while (x >= 0
                            && x < table.GetLength(0)
                            && y >= 0
                            && y < table.GetLength(1))
                        {
                            if (table[x, y])
                            {
                                canPlaceQueen = false;
                                break;
                            }

                            x += dx[di];
                            y += dy[di];
                        }
                    }

                    if (canPlaceQueen)
                    {
                        table[i, j] = true;
                        tota
                    }
                }
            }
        }

        public static void Main()
        {

        }
    }
}
