namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            Console.WriteLine("Enter Number");
            int Inter = int.Parse(Console.ReadLine());

            for(int i = 1; i <= Inter; i++)
            {
                Console.WriteLine(i);
            }

            #endregion
        }
    }
}
