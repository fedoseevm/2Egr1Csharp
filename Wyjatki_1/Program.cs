using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wyjatki_1
{
    public class WrongValueException : Exception
    {
        public WrongValueException() { }
        public WrongValueException(int value) : base(String.Format($"Podana wartość {value} jest poza zakresem <1;2>")) { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // try catch
            // Zrobić przykład z sortowaniem losowej tablicy 5 cyfr
            // - Jeśli user poda 1 to posortuj rosnąco i wyświetl
            // - Jeśli user poda 2 to posortuj malejąco i wyświetl
            // -
            Random r = new Random();
            int[] tablica = new int[5];
            Console.Write("Tablica: ");
            for (int i = 0; i < tablica.Length; i++)
            {
                tablica[i] = r.Next(1,10);
                Console.Write(tablica[i] + " ");
            }

            Console.Write("\nPodaj 1 albo 2: ");
            try
            {
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        
                        break;
                    case 2:

                        break;
                    default:
                        throw new WrongValueException(input);
                        // Zadanie: Przeznaczyć odpowiedzialność za sprawdzenie podanek liczby na wyjątek WrongValueException
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Błędny format danych");
            }
            catch (WrongValueException message)
            {
                Console.WriteLine(message);
            }
        }
        //public int[] BubbleSort(int[] table)
        //{
        //    for (int i =)
        //}
    }
}
