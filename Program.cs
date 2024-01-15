using System.Collections.Concurrent;
using System.Security.Cryptography.X509Certificates;

namespace mince
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Hazim(100) + " procent"); 
        }
        public static double Hazim(int pocet)
        {
            int count = 0;
            for (int i = 0; i < pocet; i++)
            {
                count += Hod();
            }
            double percent = (count / (double)pocet) * 100;
            return percent;
        }
        public static int Hod()
        {
            int last = 0;
            int serie = 0;
            int count = 0;
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                //1 - panna, 0 - orel
                //tohle pujde na github
                int a = random.Next(0, 2);
                if (a == 1)
                {
                    serie += 1;
                    if (serie == 7)
                    {
                        count += 1;
                        break;
                    }
                }
                else
                {
                    serie = 0;
                    last = a;
                }
            }
            return count;
        }
    }
}