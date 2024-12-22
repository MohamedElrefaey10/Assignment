using System.Globalization;

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

        int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < Numbers.Length; i++)
            {
                // Number[i] += 10;
                Console.WriteLine(Numbers[i]);
            }
            foreach (int Number in Numbers)
            {
                // X  Number +=10;  // invalid
                Console.WriteLine(Number + 10);
            }

            for (int i= 0; i< Numbers.Length; i++)
            {
                if (Numbers[i] == 5)
                {
                    continue;
                    break;
                }
                Console.WriteLine(Numbers[i]);
            }

         
        #endregion
        #endregion
    }
}
