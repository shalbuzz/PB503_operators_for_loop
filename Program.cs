namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            for (int i = 1; i <= 100; i++)
            {
               if (i % 3 == 0 && i % 5 == 0)
               {
                   num += i;
                   Console.WriteLine("Is number:" + i);
               }
            }

            byte num = 91;
            if (num < 65)
            {
               Console.WriteLine("Kesildin");
            }
            else if (num >= 65 && num < 85)
            {
               Console.WriteLine("Adi Diplom");
            }
            else if (num >= 85 && num < 95)
            {
               Console.WriteLine("Seref Diplomu");
            }
            else
            {
               Console.WriteLine("Yuksek Şeref Diplomu");
            }
        }
    }
}
