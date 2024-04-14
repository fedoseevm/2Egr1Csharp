using System.Collections;
using System.Security.Cryptography;

namespace Kolekcje_przygotowanie_S2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Wpisz do tablicy T 5 losowych liczb dwucyfrowych. Stwórz tablicę W liczb parzystych znajdujących się między minimalną i maksymalną wartością z tablicy T.
            void zadanie1()
            {
                Console.WriteLine("Zadanie 1.\n");
                Random r = new Random();
                int[] T = new int[5];
                Console.WriteLine("Tablica T: ");
                for (int i = 0; i < T.Length; i++)
                {
                    T[i] = r.Next(10, 100);
                    Console.Write(T[i] + " ");
                }
                Console.WriteLine();

                int dlugosc = 0;
                for (int i = T.Min(); i < T.Max(); i++)
                {
                    if (i % 2 == 0)
                        dlugosc++;
                }

                int[] W = new int[dlugosc];
                int k = 0;
                Console.WriteLine("\nTablica W: ");
                for (int i = T.Min(); i < T.Max(); i++)
                {
                    if (i % 2 == 0)
                    {
                        W[k] = i;
                        Console.Write(W[k] + " ");
                        k++;
                    }
                }
            }
            // zadanie1();


            // 2. Utwóz ArrayListę A zawierającą 10 losowych słów 3-literowych. Wypisz słowo o najwiekszej sumie kodów ASCII jego liter.
            void zadanie2()
            {
                Console.WriteLine("Zadanie 2.");
                Random r = new Random();
                ArrayList A = new ArrayList();
                int n = 10;
                for (int i = 0; i < n; i++)
                {
                    A.Add(Convert.ToString((char)r.Next(65, 91)) + Convert.ToString((char)r.Next(65, 91)) + Convert.ToString((char)r.Next(65, 91)));
                    Console.WriteLine(A[i]);
                }
                Dictionary<int, string> SumASCIIWordPairs = new Dictionary<int, string>();  // Tworzenie słownika, który będzie przechowywał sumę kodów ASCII napisu (suma_ascii) jako klucz i sami napisy jako wartość
                int max_suma_ascii = 0;
                for (int i = 0; i < n; i++)
                {
                    string napis = Convert.ToString(A[i]);
                    int suma_ascii = 0;
                    for (int j = 0; j < 3; j++)
                    {
                        suma_ascii += (int)napis[j];
                    }
                    SumASCIIWordPairs[suma_ascii] = napis;  // Wypełnienie słownika napisami i kluczami
                    if (suma_ascii > max_suma_ascii)
                        max_suma_ascii = suma_ascii;
                }
                Console.WriteLine("słowo o najwiekszej sumie kodów ASCII jego liter: {0}", SumASCIIWordPairs[max_suma_ascii]);
            }
            // zadanie2();


            // 3. Stwórz listę L składającą się z 10 list 10 losowych cyfr. Oblicz sumę maksymalnych cyfr w listach listy L oraz sprawdź czy istnieje taka lista gdzie wylosowano 3 identyczne cyfry.
            void zadanie3()
            {
                Console.WriteLine("Zadanie 3.");
                Random r = new Random();
                List<List<int>> L = new List<List<int>>();
                int sum_max_cyfr = 0;
                for (int i = 0; i < 10; i++)
                {
                    L.Add(new List<int>());
                    for (int j = 0; j < 10; j++)
                    {
                        L[i].Add(r.Next(0, 10));
                    }
                    sum_max_cyfr += L[i].Max();
                }
                Console.WriteLine("Suma maksymalnych cyfr w listach listy L: {0}", sum_max_cyfr);

                for (int i = 0; i < 10; i++)
                {
                    int[] Counter = new int[10];
                    for (int j = 0; j < 10; j++)
                    {
                        Counter[L[i][j]]++;
                    }
                    if (Counter.Contains(3))
                    {
                        Console.WriteLine($"Lista {i + 1}: Wylosowano 3 identyczne cyfry");
                        break;
                    }
                    Console.WriteLine($"Lista {i + 1}: Nie wylosowano 3 identyczne cyfry");
                }
            }
            // zadanie3();


            // 4. Stwórz słownik D kluczami i = 1, 2, 3 ... n (user podaje n) oraz wartościami i-cyfrowych dzielników liczby 10 do potęgi i dla każdego kluczy.
            void zadanie4()
            {
                Console.WriteLine("Zadanie 4.");
                Dictionary<int, List<int>> D = new Dictionary<int, List<int>>();
                Console.Write("Podaj ilosc kluczy w słowniku: ");
                int n = int.Parse(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    D[i] = new List<int>();
                    for (int j = (int) Math.Pow(10, i - 1); j < (int) Math.Pow(10, i); j += (int) Math.Pow(5, i - 1))   // Z każdym krokiem do j można dodawać 1 zamiast (int) Math.Pow(5, i - 1), ale w moim przypadku jest optymalniej.
                    {
                        if (Math.Pow(10, i) % j == 0)
                            D[i].Add(j);
                    }
                }

                foreach (KeyValuePair<int, List<int>> item in D)
                {
                    Console.WriteLine(item.Key + ": ");
                    foreach (int dzielnik in item.Value)
                    {
                        Console.Write(dzielnik + " ");
                    }
                    Console.WriteLine("\n");
                }
            }
            //zadanie4();


            // 5. Korzystając ze słownika utwórz graf G zbudowany z n wierzchołków i k krawędzi. 
            // Policz wierzchołki nie mające żadnych sąsiadów.
            void zadanie5()
            {
                Console.WriteLine("Zadanie 5.");
                Dictionary<int, List<int>> G = new Dictionary<int, List<int>>();
                Console.Write("Podaj ilość wierzchołków n: ");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    G.Add(i, new List<int>());
                }

                Console.Write("Podaj ilość krawędzi k: ");
                int k = int.Parse(Console.ReadLine());
                string[] Liczby;
                int a, b;
                for (int i = 0; i < k; i++)
                {
                    Liczby = Console.ReadLine().Split();
                    a = int.Parse(Liczby[0]);
                    b = int.Parse(Liczby[1]);
                    G[a].Add(b);
                    G[b].Add(a);
                }
                Console.Write("Wierzchołki nie mające żadnych sąsiadów: ");
                foreach (var index in G.Keys)
                {
                    if (G[index].Count == 0)
                        Console.Write(index + " ");
                }
            }
            zadanie5();
        }
    }
}