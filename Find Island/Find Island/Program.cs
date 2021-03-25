using System;
using System.Linq;

namespace Find_Island
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new int[][]
            {
                new int[]{1,1,0},
                new int[]{1,0,1},
                new int[]{1,0,1}
            };

            int CountIsland(int[][] arr)
            {
                int count = 0;

                for(int i = 0; i < arr.Length; i++)
                {
                    for(int j = 0; j < arr[i].Length; j++)
                    {
                        if(CheckAround(arr, i, j))
                        {
                            count++;
                        }
                    }
                }
                return count;
            }
            bool CheckAround(int[][] arr, int posI, int posJ)
            {
                {
                    if ((posI < 0) || (posI >= arr.Length))
                    {
                        return false;
                    }
                    if ((posJ < 0) || (posJ >= arr[posI].Length))
                    {
                        return false;
                    }

                    bool island = arr[posI][posJ] == 1;

                    arr[posI][posJ] = 0;

                    if (island)
                    {
                        CheckAround(arr, posI, posJ + 1);
                        CheckAround(arr, posI, posJ - 1);
                        CheckAround(arr, posI + 1, posJ);
                        CheckAround(arr, posI - 1, posJ);
                    }

                    return island;
                }
            }
            Console.WriteLine(CountIsland(array));
        }


    }
}
