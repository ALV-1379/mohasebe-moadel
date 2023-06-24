using System;

namespace mohasebe_moadel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nomre mian term ra vared konid");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nomre payan term ra vared konid");
            double b = Convert.ToDouble(Console.ReadLine());


            static Double miangin(double a, double b)
            {
                double mianterm = (a * 100) / 35;
                double payanterm = (b * 100) / 65;
                return mianterm + payanterm;
            }
            Console.ReadKey();
        }
    }
}
