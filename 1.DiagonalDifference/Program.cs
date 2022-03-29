using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.Write("Input number of rows:");
            n = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[n, n];


            for(int rowstring = 0; rowstring<n; rowstring++)
            {
                string rows = Console.ReadLine();
                string[] rowArray = rows.Split(' ');
                for (int rowarrayLoop = 0; rowarrayLoop < rowArray.Length; rowarrayLoop++)
                {
                    string temp = rowArray[rowarrayLoop];
                    arr[rowstring, rowarrayLoop] = int.Parse(rowArray[rowarrayLoop]);
                }
            }

            Console.WriteLine("RESULT : " + Dia(arr, n));
            Console.ReadKey();
        }


        static int Dia(int[,] arr, int n)
        {
            int primaryDiagonal = 0, secondaryDiagonal = 0;
            int secondaryDiagonalctr = n - 1;
            for (int i = 0; i < n; i++)
            {
                primaryDiagonal += arr[i, i];
                secondaryDiagonal += arr[i, secondaryDiagonalctr];
                secondaryDiagonalctr--;
            }
            return GetAbsoluteValue(primaryDiagonal - secondaryDiagonal);// across the diagonals
        }

        static int GetAbsoluteValue(int result)
        {
            return result > 0 ? result : result * -1;
        }
    }
}
