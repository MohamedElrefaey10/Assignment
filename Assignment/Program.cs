using System.Text;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //Console.WriteLine("Enter Number");
            //int Inter = int.Parse(Console.ReadLine());

            //for(int i = 1; i <= Inter; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q2


            //Console.WriteLine("Enter Number");
            //int Inter = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(Inter * i);
            //}

            #endregion

            #region Q3

            //Console.WriteLine("Enter Number");
            //int Inter = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= Inter; i++)
            //{
            //    if (i % 2 == 1)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}
            #endregion

            #region Q4

            //string xxx = Console.ReadLine();
            //string[] w = xxx.Split(' ');

            //int x = int.Parse(w[0]);
            //int y = int.Parse(w[1]);

            //double result = Math.Pow(x, y);
            //Console.WriteLine(result);
            #endregion

            #region Q5

            //Console.WriteLine("Enter string");
            //string messag = Console.ReadLine();

            //StringBuilder xx = new StringBuilder();
            //for (int i = messag.Length - 1; i >= 0; i--)
            //{
            //    xx.Append(messag[i]);

            //}
            //Console.WriteLine(xx);

            #endregion

            #region Q6


            #endregion

            #region Q7
            //Console.WriteLine("Enter Number");
            //int x = int.Parse(Console.ReadLine());

            //StringBuilder xxx = new StringBuilder();
            //while (x > 0)
            //{
            //    int aa = x / 2;
            //    int bb = x % 2;
            //    xxx.Insert(0, bb);
            //    x = aa;
            //}
            //Console.WriteLine(xxx);
            #endregion

            #region Q8
            //Console.WriteLine("Enter Number");
            //int x = int.Parse(Console.ReadLine());

            //for(int i =1; i <= x; i++)
            //{
            //    for(int k = 1; k <= x; k++)
            //    {
            //        if (i == k)
            //            Console.Write("1");
            //        else
            //            Console.Write("0");

            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Q9
            //Console.WriteLine("Enter Streng");
            //string name = Console.ReadLine();
            //Console.Write("index Start : ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("index End : ");
            //int y = int.Parse(Console.ReadLine())-1;

            //Console.WriteLine(name.Substring(x,y));


            #endregion

            #region Q10
            //Console.WriteLine("Enter Streng01");
            //string st01 = Console.ReadLine();
            //Console.WriteLine("Enter Streng02");
            //string st02 = Console.ReadLine();

            //String massage;
            //massage = st01 + $" {st02}";

            //Console.WriteLine(massage);

            //// ********* StringBuilder
            //Console.WriteLine("Enter Streng01");
            //StringBuilder st11 = new StringBuilder( Console.ReadLine());
            //Console.WriteLine("Enter Streng02");
            //StringBuilder st22 = new StringBuilder( Console.ReadLine());

            //StringBuilder massage2 = new StringBuilder();
            //massage2.Append(st11);
            //massage2.Append($" {st22}");

            //Console.WriteLine(massage);

            #endregion

            #region Q11
            //Console.WriteLine("Enter Number");
            //int x = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= x; i++)
            //{
            //    for (int k = 1; k <= x; k++)
            //    {
            //        if (i == k)
            //            Console.Write("1");
            //        else
            //            Console.Write("0");

            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Q12
            int[] number = { 1, 2, 3, 4, 5,6 };
            int y = 0; 
            for(int i = 0; i < number.Length; i++)
            {
                y += number[i];
            }
            Console.WriteLine(y);
            #endregion
        }
    }
}
