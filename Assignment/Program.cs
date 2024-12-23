using System.Globalization;
using System.Text;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Video 01
            #region loop Statments

            //Console.WriteLine("1 T");
            //Console.WriteLine("2 T");
            //Console.WriteLine("3");
            //Console.WriteLine("4");
            //Console.WriteLine("5");
            //Console.WriteLine("6");
            //Console.WriteLine("7");
            //Console.WriteLine("8");
            //Console.WriteLine("9");
            //Console.WriteLine("10");

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i} T");
            //}

            #endregion
            #endregion

            #region video 02
            #region For - Foreach

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    // Number[i] += 10;
            //    Console.WriteLine(Numbers[i]);
            //}
            //    foreach (int Number in Numbers)
            //    {
            //        // X  Number +=10;  // invalid
            //        Console.WriteLine(Number + 10);
            //    }

            //    for (int i= 0; i< Numbers.Length; i++)
            //    {
            //        if (Numbers[i] == 5)
            //        {
            //            continue;
            //            break;
            //        }
            //        Console.WriteLine(Numbers[i]);
            //    }


            #endregion
            #endregion

            #region video 03

            #region While - Do While

            //int Number;
            //do
            //{
            //    Console.WriteLine("Enter Even Number");
            //} while (Number % 2 == 1);
            //Console.WriteLine($"{Number} is Even");

            //int Number2;
            //do
            //{
            //    Console.WriteLine("Enter Even Number");
            //    flag = int.TryParse(Console.ReadLine(), out Number2);
            //} while (Number2 % 2 == 1);
            //Console.WriteLine($"{Number2}is Even");

            //int Number3 = 3;
            //bool flag3 = false;
            //while(Number3 % 2==1 || !flag3)
            //{
            //    Console.WriteLine("Enter Even Number");
            //    flag3 = int.TryParse(Console.ReadLine(), out Number3);
            //}
            //Console.WriteLine($"{Number3} is EVen");
            #endregion
            #endregion

            #region video 04

            #region String

            //string Name; 
            //Name = new string("ahmed");
            //Name = "ahmed";

            //string Name01 = "Ahmed";
            //string Name02 = "Ahmed";

            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name01 HC : {Name02.GetHashCode()}");

            //Name02 = Name01;
            //Console.WriteLine("**************************");

            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name01 HC : {Name02.GetHashCode()}");

            //Name01 = "mostafa";
            //Console.WriteLine("**************************");

            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name01 HC : {Name02.GetHashCode()}");

            #endregion
            #endregion

            #region video 05
            #region string builder
            //StringBuilder message;
            //message = new StringBuilder("Hello");

            //Console.WriteLine(message);
            //Console.WriteLine(message.GetHashCode());

            //StringBuilder message02 = new StringBuilder("Welcom");

            //message02.Append("To Route");
            //message02.AppendLine(" mohamed");
            //message02.Append("abdullah");

            //message02.Remove(0, 5);
            //message02.Insert(0, "hello");


            #endregion
            #endregion

            #region video 06

            #region Array D1
            //int[] numbers = new int[3] { 1, 2, 3 };
            //int[] numbers2 = new int[] { 1, 2, 3 };
            //int[] numbers3 = { 1, 2, 3 };
            //int[] numbers4 = new int[3];

            //numbers[0] = 1;
            //numbers[1] = 2;
            //numbers[2] = 3;

            //for(int i =0; i< numbers.Length; i++)
            //{
            //    numbers[i] = i + 1;
            //}
            //Console.WriteLine("*************");

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //Console.WriteLine(numbers.Length);
            //Console.WriteLine(numbers.Rank);
            #endregion
            #endregion

            #region video 07

            #region 2D Array
            int[,] mrks1 = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 }, { 100, 200, 300, 400, 500 } };

            Console.WriteLine(mrks1.Length);
            Console.WriteLine(mrks1.Rank);
            Console.WriteLine(mrks1.GetLength(0));
            Console.WriteLine(mrks1.GetLength(1));

            int[] Marks = new int[3, 5];
            for (int i = 0; i < Marks.GetLength(0); i++)
            {
                Console.WriteLine($"Enter Grades Student{i + 1}");
                for(int k = 0; k < Marks.GetLength(1))
                {
                    bool flag;
                    Console.WriteLine($"Enter Grades Student{k + 1}");
                    flag = int.TryParse(Console.ReadLine(), out Marks[i+ k]);
                    k = flag && Marks[i, k] >= 0 ? ++k::k;
                }
            }

            #endregion

            #endregion

        }
    }
}
