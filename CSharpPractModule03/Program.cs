using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractModule03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            double[,] B = new double[3, 4];

            double multiplie = 1;
            int sumEven = 0;
            double sumOdd = 0;
           
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter numeric value for A " + i + ": ");
                A[i] = Convert.ToInt32(Console.ReadLine());
                multiplie *= A[i];
                if (A[i] % 2 == 0) sumEven += A[i];
            }

            Console.WriteLine("Values of array B is: ");
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = rand.Next(1, 10);
                    Console.Write(B[i, j] + "\t");
                    multiplie *= B[i, j];
                    if (B[i, j] % 2 != 0) sumOdd += B[i, j];

                }
                Console.WriteLine();
            }
            double sum  = A.Cast<int>().Sum() + B.Cast<double>().Sum();


            double maxB = B.Cast<double>().Max();
            double minB = B.Cast<double>().Min();

            double maxA = A.Cast<int>().Max();
            double minA = A.Cast<int>().Min();

            double max = 0;
            double min = 0;
            if (maxA > maxB) max = maxA;
            else max = maxB;

            if (minA < minB) min = minA;
            else min = minB;

            Console.WriteLine();
            Console.WriteLine("Values of array A is: ");
            for (int i = 0; i < 5; i++)
            {
            Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Max element is " + max);
            Console.WriteLine("Min element is " + min);
            Console.WriteLine("Sum of all elements in arrays is " + sum);
            Console.WriteLine("Multiplie of all elements in arrays is " + multiplie);
            Console.WriteLine("Sum of all even in array A is " + sumEven);
            Console.WriteLine("Sum of all odd in array B is " + sumOdd);


            Console.ReadLine();
        }
    }
}
