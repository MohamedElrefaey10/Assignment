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
            
            Console.WriteLine("Enter string");
            string messag = Console.ReadLine();

            StringBuilder xx = new StringBuilder();
            for (int i = messag.Length - 1; i >= 0; i--)
            {
                xx.Append(messag[i]);

            }
            Console.WriteLine(xx);

            #endregion
        }
    }
}
