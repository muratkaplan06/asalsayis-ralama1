using System;

namespace asalsayisıralama
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,i,j,bayrak;
            Console.Write("kaca kadar sayi olusturulacak:");
            n = Convert.ToInt32(Console.ReadLine());
            for (i= 2; i < n; i++)
            {
                bayrak = 1;
                for (j = 2; j < i; j++)
                    if (i % j == 0)
                        bayrak = 0;
                if (bayrak == 1 && i % 2 != 0)
                Console.WriteLine(i);
            }
        }
    }
}
