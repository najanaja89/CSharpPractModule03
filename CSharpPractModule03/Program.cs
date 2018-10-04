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

            //Task1.
            string menu = "";
            Console.WriteLine("Press 1 to task 1");
            Console.WriteLine("Press 2 to task 2");
            Console.WriteLine("Press 3 to task 3");
            Console.WriteLine("Press 4 for task four");
            Console.WriteLine("Press 5 for task five");
            menu = Console.ReadLine();
            Random rand = new Random();

            if (menu == "1")
            {
                Console.WriteLine("Task1");
                int[] A = new int[5];
                double[,] B = new double[3, 4];

                double multiplie = 1;
                int sumEven = 0;
                double sumOdd = 0;


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
                double sum = A.Cast<int>().Sum() + B.Cast<double>().Sum();


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

                Console.WriteLine();
                Console.WriteLine();
            }

            else if (menu == "2")
            {
                //Task2.
                Console.WriteLine("Task2");
                Console.WriteLine("Enter N value ");
                string stringN = Console.ReadLine();
                Console.WriteLine("Enter M value ");
                string stringM = Console.ReadLine();

                bool result = int.TryParse(stringN, out int N);
                if (result == false) Console.WriteLine("N is numeric value!");
                result = int.TryParse(stringM, out int M);
                if (result == false) Console.WriteLine("M is numeric value!");

                int[] arrayM = new int[M];
                int[] arrayN = new int[N];
                int[] arrayThree = new int[N + M];

                for (int i = 0; i < M; i++)
                {
                    arrayM[i] = rand.Next(1, 10);
                    Console.Write(arrayM[i] + " ");
                }
                Console.WriteLine();

                for (int i = 0; i < N; i++)
                {
                    arrayN[i] = rand.Next(1, 10);
                    Console.Write(arrayN[i] + " ");
                }

                Console.WriteLine();
                int tmp = 0;
                if (N < M) tmp = N;
                else tmp = M;

                for (int i = 0; i < tmp; i++)
                {
                    int repeat = 0;

                    for (int j = 0; j < tmp; j++)
                    {
                        if (repeat == 0)
                        {
                            if (arrayN[i] == arrayM[j])
                            {
                                arrayThree[i] = arrayN[j];
                                repeat++;
                            }
                        }
                    }

                    Console.Write(arrayThree[i] + " ");
                }
            }

            else if (menu == "3")
            {
               
                Console.WriteLine("Enter string to check on palindrome");
                string palindrome = Console.ReadLine();

                Console.WriteLine();
                palindrome.ToLower();
                char[] arrayChar = palindrome.ToCharArray();
                Array.Reverse(arrayChar);
                char[] tmp = palindrome.ToCharArray();

                Console.WriteLine(arrayChar);
                Console.WriteLine(tmp);

                int count = 0;
                for (int i = 0; i < arrayChar.Length; i++)
                {
                    if (arrayChar[i] == tmp[i]) count++;
                }

                if (count !=0)
                {
                    Console.WriteLine("String is palindrome");
                }
                else Console.WriteLine("String  is not palindrome");
                Console.ReadLine();
            }
            
        }
    }
}
