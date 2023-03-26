using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] stats = new int[2];
            int[] helpArr;
            double[,] outputArr = new double[n, 3];
            int[,] finalHelper;
            int[] finalRow = new int[n];
            int counterFinal = 0;
            int min = int.MaxValue;
            int max = int.MinValue;
            double sum = 0;
            double elements;
            for (int s1 = 0; s1 < n; s1++)
            {
                stats = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                elements = stats[0] * stats[1];
                helpArr = new int[stats[1]];
                finalHelper = new int[stats[0], stats[1]];
                for (int s2 = 0; s2 < stats[0]; s2++)
                {
                    helpArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                    for (int s3 = 0; s3 < stats[1]; s3++)
                    {
                        finalHelper[s2, s3] = helpArr[s3];
                        if (helpArr[s3] < min)
                        {
                            min = helpArr[s3];
                        }
                        if (helpArr[s3] > max)
                        {
                            max = helpArr[s3];
                        }
                        sum += helpArr[s3];
                    }                    
                }
                for (int s4 = 0; s4 < stats[0]; s4++)
                {
                    for (int s41 = 0; s41 < stats[1]; s41++)
                    {
                        if (finalHelper[s4, s41] > Math.Ceiling(sum / elements)) 
                        {
                            Console.WriteLine(finalHelper[s4, s41]);
                            counterFinal++;
                        }
                    }
                }
                finalRow[s1] = counterFinal;
                outputArr[s1, 0] = min;
                outputArr[s1, 1] = max;
                outputArr[s1, 2] = Math.Round(sum / elements, 2);
                min = int.MaxValue;
                max = int.MinValue;
                sum = 0;
                counterFinal = 0;
            }
            for (int s1 = 0; s1 < n; s1++)
            {
                for (int s2 = 0; s2 < 3; s2++)
                {
                    Console.Write(outputArr[s1, s2] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(string.Join(" ", finalRow));
        }
    }
}
