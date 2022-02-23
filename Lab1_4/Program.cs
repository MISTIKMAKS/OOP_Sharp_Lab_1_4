using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double P, S;
            int n, k;
            P = 1;
            n = 1;
            while (n <= 20)
{
                S = 0;
                k = 1;
                while (k <= n)
{
                    S += k;
                    k++;
                }
                P *= ((n * n) + Math.Pow(S, 2)) / (n + 1);
                n++;
            }
            Console.WriteLine("{0}", P);
            P = 1;
            n = 1;
            do
            {
                S = 0;
                k = 1;
                do

                {
                    S += k;
                    k++;
                } while (k <= n);
                P *= ((n * n) + Math.Pow(S, 2)) / (n + 1);
                n++;
            } while (n <= 20);
            Console.WriteLine("{0}", P);
            P = 1;
            for (n = 1; n <= 20; n++)
            {
                S = 0;
                for (k = 1; k <= n; k++)
                {
                    S += k;
                }
                P *= ((n * n) + Math.Pow(S, 2)) / (n + 1);
            }
            Console.WriteLine("{0}", P);
            P = 1;
            for (n = 20; n >= 1; n--)
            {
                S = 0;
                for (k = n; k >= 1; k--)
                {
                    S += k;
                }
                P *= ((n * n) + Math.Pow(S, 2)) / (n + 1);
            }
            Console.WriteLine("{0}", P);
            Console.ReadKey();
        }
    }
}
