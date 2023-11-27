using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // idea rekurencji
            // reku utożsamiaj z pętlą
            // 3 elementy pętli: start, stop, step
            Console.WriteLine("ZADANIE 1");
            int reku1(int n)
            {
                if (n == 0) return 1;
                return reku1(n - 1) * n;
            }
            Console.WriteLine(reku1(5));
            Console.WriteLine("\n");
            // reku1(5)     =>  24 * 5 = 120
            // reku1(4)     =>  6 * 4
            // reku1(3)     =>  2 * 3
            // reku1(2)     =>  1 * 2
            // reku1(1)     =>  1 * 1
            // reku1(0)     =>  1




            Console.WriteLine("ZADANIE 2");
            void reku2(int n)
            {
                if (n == 0) return;
                reku2(n - 1);
                Console.WriteLine(n);
            }
            reku2(5);

            // reku2(5)     5
            // reku2(4)     4
            // reku2(3)     3
            // reku2(2)     2
            // reku2(1)     1
            // reku2(0)     ...

            Console.WriteLine("\n");
            // zad 3
            Console.WriteLine("ZADANIE 3");
            // Algorytm, sumujące cyfry
            // ITERACYJNIE
            int suma3 = 0;
            for (int i = 0; i < 10; i++)
                suma3 += i;
            Console.WriteLine(suma3);

            // REKURENCYJNIE
            int reku3(int n)
            {
                if (n == 0) return 0;
                return reku3(n - 1) + n;
            }
            Console.WriteLine(reku3(9));

            int reku3inaczej(int n)
            {
                if (n == 0) return 0;
                int w = reku3inaczej(n - 1) + n;
                return w;
            }
            Console.WriteLine(reku3inaczej(9));

            Console.WriteLine("\n");
            // Zad 4 
            Console.WriteLine("ZADANIE 4");
            // alg sumujący liczby dwucyfrowe parzyste
            int reku4(int n)
            {
                if (n < 10) return 0;
                return reku4(n - 2) + n;

                //if (n == 10) return 10;
                //return reku4(n - 2) + n;
            }
            Console.WriteLine(reku4(98));


            // ITERACYJNIE
            int sum4 = 0;
            for (int i = 10; i <= 98; i += 2)
            {
                sum4 += i;
            }
            Console.WriteLine(sum4);

            Console.WriteLine("\n");
            // Zad 5
            Console.WriteLine("ZADANIE 5");
            // Alg obliczający sumę ciągów

            // a) 3, 6, 9, 12 ... <=> 3 + 6 + 9 + 12 = 3(1 + 2 + 3 + 4)
            int reku5a(int n)
            {
                if (n == 1) return 3;
                return reku5a(n - 1) + 3 * n;
            }
            Console.WriteLine("a) " + reku5a(4));


            // b) 12, 23, 34, 45 ...
            int reku5b(int n)
            {
                if (n == 1) return 12;
                return reku5b(n - 1) + 11;
            }
            Console.WriteLine("b) " + reku5b(5));

            int suma5b = 0;
            for (int i = 0; i < 5; i++)
            {
                suma5b += 1 + (i + 1) * 11;
            }
            Console.WriteLine(suma5b);


            // c) 2, 6, 18, 54            
            int suma5c = 0;
            for (int i = 0; i < 4; i++)
            {
                suma5c += 2 * (int) Math.Pow(3, i);
            }
            Console.WriteLine("c) " + suma5c);

            int reku5c(int n)
            {
                if (n == 1) return 2;
                return reku5c(n - 1) * 3;
            }
            Console.WriteLine("   " + reku5c(4));

            int suma5c2 = 0;
            for (int i = 0; i < 4; i++)
            {
                suma5c2 += reku5c(i + 1);
            }
            Console.WriteLine("   " + suma5c2);

            Console.WriteLine("\n");
            // Zad 6
            Console.WriteLine("ZADANIE 6");
            // a) 1.5, 1, 0.5, -0.5, -2, -4.5, -8.5, -15, ...
            double reku6a(int n)
            {
                if (n == 1) return 1.5;
                if (n == 2) return 1;
                if (n == 3) return 0.5;
                return 2 * reku6a(n - 1) - reku6a(n - 3);
            }
            for (int i = 0; i < 9; i++)
            {
                Console.Write(reku6a(i + 1) + " ");
            }
            Console.WriteLine("\n");

            // b) -2, 2.5, 3, -5, 7.5, -4.5, -0.5, 8, 12.5
            double reku6b(int n)
            {
                if (n == 1) return -2;
                if (n == 2) return 2.5;
                if (n == 3) return 3;
                return - reku6b(n - 1) +  reku6b(n - 3);
            }
            for (int i = 0; i < 9; i++)
            {
                Console.Write(reku6b(i + 1) + " ");
            }
            Console.WriteLine("\n");


            // c) 0 1 -1 2 -2 3 -3 4 -4
            int reku6c(int n)
            {
                if (n == 0) return 0;
                if (n == 1) return 1;
                if (n % 2 == 0) return reku6c(n - 2) - 1;
                else return reku6c(n - 2) + 1;
            }
            for (int i = 0; i < 9; i++)
            {
                Console.Write(reku6c(i) + " ");
            }
            Console.WriteLine("\n");


            // d) 1 3 4 8 15 27 ...


            // 4 5 -3 2 14 22 48 
            // 2 * 4 + 2 * (-3) = 2


            // 1 1 1 6 11 31
        }
    }
}
