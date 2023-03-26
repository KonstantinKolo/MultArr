using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultArr
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int sum = int.MinValue;
            int cordX = 0;
            int cordY = 0;
            int[] helpArr = new int[row];
            int[,] codeArr = new int[row, col];
            for (int s1 = 0; s1 < row; s1++)
            {
                helpArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int s2 = 0; s2 < col; s2++)
                {
                    codeArr[s1, s2] = helpArr[s2];
                }
            }
            for (int s1 = 0; s1 < row - 1; s1++)
            {
                for (int s2 = 0; s2 < col - 1; s2++) 
                {
                    if (codeArr[s1, s2] + codeArr[s1, s2 + 1] + codeArr[s1 + 1, s2] + codeArr[s1 + 1, s2 + 1] > sum)
                    {
                        sum = codeArr[s1, s2] + codeArr[s1, s2 + 1] + codeArr[s1 + 1, s2] + codeArr[s1 + 1, s2 + 1];
                        cordX = s1;
                        cordY = s2;
                    }
                }
            }
            Console.WriteLine($"{codeArr[cordX, cordY]} {codeArr[cordX, cordY + 1]}\n{codeArr[cordX + 1, cordY]} {codeArr[cordX + 1, cordY + 1]}");
        }
    }
}
