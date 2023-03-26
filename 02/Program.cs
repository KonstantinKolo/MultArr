using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] inputArr = new char[3, 3];
            char[] helpArr = new char[3];
            for (int s1 = 0; s1 < 3; s1++)
            {
                helpArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
                for (int s2 = 0; s2 < 3; s2++)
                {
                    inputArr[s1, s2] = helpArr[s2];
                }
            }
            if (inputArr[0, 0] == 'X' && inputArr[0, 1] == 'X' && inputArr[0, 2] == 'X' ||
                inputArr[1, 0] == 'X' && inputArr[1, 1] == 'X' && inputArr[1, 2] == 'X' ||
                inputArr[2, 0] == 'X' && inputArr[2, 1] == 'X' && inputArr[2, 2] == 'X' ||
                inputArr[0, 0] == 'X' && inputArr[1, 1] == 'X' && inputArr[2, 2] == 'X' ||
                inputArr[0, 2] == 'X' && inputArr[1, 1] == 'X' && inputArr[3, 0] == 'X' ||
                inputArr[0, 0] == 'X' && inputArr[1, 0] == 'X' && inputArr[2, 0] == 'X' ||
                inputArr[0, 1] == 'X' && inputArr[1, 1] == 'X' && inputArr[2, 1] == 'X' ||
                inputArr[0, 2] == 'X' && inputArr[1, 2] == 'X' && inputArr[2, 2] == 'X' )
            {
                Console.WriteLine("The winner is: X");
            }
            else if (inputArr[0, 0] == 'O' && inputArr[0, 1] == 'O' && inputArr[0, 2] == 'O' ||
                     inputArr[1, 0] == 'O' && inputArr[1, 1] == 'O' && inputArr[1, 2] == 'O' ||
                     inputArr[2, 0] == 'O' && inputArr[2, 1] == 'O' && inputArr[2, 2] == 'O' ||
                     inputArr[0, 0] == 'O' && inputArr[1, 1] == 'O' && inputArr[2, 2] == 'O' ||
                     inputArr[0, 2] == 'O' && inputArr[1, 1] == 'O' && inputArr[3, 0] == 'O' ||
                     inputArr[0, 0] == 'O' && inputArr[1, 0] == 'O' && inputArr[2, 0] == 'O' ||
                     inputArr[0, 1] == 'O' && inputArr[1, 1] == 'O' && inputArr[2, 1] == 'O' ||
                     inputArr[0, 2] == 'O' && inputArr[1, 2] == 'O' && inputArr[2, 2] == 'O' )
            {
                Console.WriteLine("The winner is: O");
            }
            else
            {
                Console.WriteLine("There is no winner");
            }
        }
    }
}
