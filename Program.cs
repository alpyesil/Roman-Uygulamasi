using System;

namespace Roman
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayfa = 10;
            int okunansayfa = 10;
            int gun = 0;

            while (okunansayfa < 1000)
            {
                okunansayfa = okunansayfa + sayfa;
                sayfa = sayfa + 5;
                gun++;
            }

            Console.WriteLine("Kitap" + " " + gun + " " + "günde bitecek");
        }
    }
}
