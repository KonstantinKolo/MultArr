using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int[,] pyramideArr = new int[h + 1, h + 1];
            pyramideArr[0, 0] = 1;
            int helper = 1;
            string spaces;
            int spaceHelp = h * 2 ;
            for (int s1 = 1; s1 <= h; s1++)
            {
                for (int s2 = 0; s2 < helper; s2++)
                {
                    if (s2 == 0)
                    {
                        pyramideArr[s1, s2] = pyramideArr[s1 - 1, s2];
                    }
                    else if (s2 == helper - 1)
                    {
                        pyramideArr[s1, s2] = pyramideArr[s1 - 1, s2 - 1];
                        Console.WriteLine(pyramideArr[s1,s2]);
                    }
                    else
                    {
                        pyramideArr[s1, s2] = pyramideArr[s1 - 1, s2] + pyramideArr[s1 - 1, s2 - 1];
                    }
                }
                helper++;
            }
            helper = 1;
            for (int s1 = 0; s1 <= h; s1++)
            {
                spaces = new string(' ', spaceHelp);
                Console.Write(spaces);
                for (int s2 = 0; s2 < helper - 1; s2++)
                {
                    Console.Write(pyramideArr[s1, s2] + "   ");
                }
                Console.WriteLine();
                spaceHelp -= 2;
                helper++;
            }
        }
    }
}
