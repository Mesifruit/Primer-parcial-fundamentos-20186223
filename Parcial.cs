using System;

namespace Borradorparcial
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cash = 0;
            int d1000, d500, d200, d100;
            int d1000L, d500L, d200L, d100L;

            d1000 = 0;
            d500 = 0;
            d200 = 0;
            d100 = 0;
            //Limites
            d1000L = 18;
            d500L = 19;
            d200L = 23;
            d100L = 50;

            Console.WriteLine("Binvenido al Banco Emilio");
            Console.WriteLine("Que Cantidad quiere retirar : ");

            Cash = int.Parse(Console.ReadLine());
            if (Cash > 20000)
            {
                Console.WriteLine("El monto es mayor de lo establecido ");
            }
            else if (Cash <= 20000)
            {
                if (Cash >= 1000)
                {
                    d1000 = (Cash / 1000);
                    Cash = Cash - (d1000 * 1000);
                    if (d1000 > 18)
                    {
                        Cash = Cash - (d1000 * 500);
                    }
                }
                if (Cash >= 500)
                {
                    d500 = (Cash / 500);
                    Cash = Cash - (d500 * 500);
                }
                if (Cash >= 200)
                {
                    d200 = (Cash / 200);
                    Cash = Cash - (d200 * 200);
                }
                if (Cash >= 100)
                {
                    d100 = (Cash / 100);
                    Cash = Cash - (d100 * 100);
                }
            }
            //Limites
            if (d1000 > d1000L)
            {
                int res1000;
                res1000 = d1000 - d1000L;
                d1000 = d1000 - res1000;
                d500 = d500 + res1000 + res1000;
            }
            if (d500 > d500L)
            {
                int res500;
                res500 = d500 - d500L;
                d500 = d500 - res500;
                d200 = d200 + res500;
            }
            if (d200 > d200L)
            {
                int res200;
                res200 = d200 - d200L;
                d500 = d500 - res200;
                d100 = d100 + res200;
            }
            if (d100 > d100L)
            {
                int res100;
                res100 = d100 - d100L;
                d500 = d500 - res100;
            }


            //Resultado
            Console.WriteLine("BILLETES DE A 1000: " + d1000);
            Console.WriteLine("BILLETES DE A 500 : " + d500);
            Console.WriteLine("BILLETES DE A 200 : " + d200);
            Console.WriteLine("BILLETES DE A 100 : " + d100);

            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}
