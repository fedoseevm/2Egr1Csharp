using System.Globalization;

namespace Kolekcje_przygotowanie
{
    internal class Program
    {
        public struct Osoba
        {
            public string imie;
            public string nazwisko;
            public int wiek;
        }

        static void Main(string[] args)
        {
            // Zadanie 1
            // Wpisz do tablicy n liczb podanych przez usera w sposob rosnacy i wypisz te z nich, ktore sa "portugalskie"
            // Liczby portugalskie - liczby samotne czyli takie ktore nie maja sasiada w otoczeniu 2.
            // WE: 5
            // 3 7 9 13 19
            // WY: 3 13 19
            void zadanie1()
            {
                Console.WriteLine("Zadanie 1");
                Console.Write("Ilosc liczb: ");
                int n = int.Parse(Console.ReadLine());
                string[] wejscie = Console.ReadLine().Split();
                int[] IntTable = Array.ConvertAll(wejscie, int.Parse);
                Array.Sort(IntTable);

                //int[] Table1 = new int[n];
                //int k = 0;
                //for (int i = IntTable.Min(); i <= IntTable.Max(); i++) // Wpisywanie podanych liczb w sposob rosnacy do Table1
                //{
                //    if (IntTable.Contains(i))
                //    {
                //        Table1[k] = i;
                //        k++;
                //    }
                //}
                Console.Write("Posortowana tablica: ");
                foreach (int i in IntTable)   // Wypisywanie posortowanej tablicy
                    Console.Write(i + " ");

                List<int> Portugalskie = new List<int>();
                for (int i = 0; i < IntTable.Length; i++)
                {
                    bool czyPortugal = true;
                    for (int j = -2; j <= 2; j++)
                    {
                        if (IntTable.Contains(IntTable[i] + j) && j != 0)
                        {
                            czyPortugal = false;
                        }
                    }
                    if (czyPortugal)
                        Portugalskie.Add(IntTable[i]);
                }
                Console.Write("\nPortugalskie: ");
                foreach (int i in Portugalskie)
                    Console.Write(i + " ");
            }
            // zadanie1();


            // Zadanie 2
            // User podaje dowolny werset z Pana Tadeusza. Sprawdź czy w tym wersecie jakaś literka występuje co najmniej 3 razy. Użyj tablica(toCharArray())
            void zadanie2()
            {
                Console.WriteLine("Podaj wiersz z Pana Tadeusza: ");
                string input = Console.ReadLine().ToLower();
                char[] charTable = input.ToCharArray();
                int[] counter = new int[26];
                foreach (char c in charTable)
                {
                    if (c != ' ')
                        counter[((int) c) - 97]++;
                }
                Console.Write("Litery, które występują co najmniej 3 razy: ");
                for (int i = 0; i < counter.Length; i++)
                {
                    if (counter[i] >= 3)
                        Console.Write((char) (97 + i) + " ");
                }
            }
            zadanie2();


            // Zadanie 3
            // User podaje dwie liczby brytyjskie. Przez liczby brytyjskie rozumiemy dwie dowolne liczby dwucyfrowe różniące się przynajmniej o 50.
            //Zapisz do listy wszystkie liczby pierwsze znajdujące się między powyższymi liczbami.
            bool IsPrime(int x)
            {
                for (int i = 2; i <= Math.Sqrt(x); i++)
                    if (x % i == 0)
                        return false;
                return true;
            }

            void zadanie3()
            {
                Console.Write("Podaj 1 liczbę: ");
                int liczba1 = int.Parse(Console.ReadLine());
                Console.Write("Podaj 2 liczbę: ");
                int liczba2 = int.Parse(Console.ReadLine());
                List<int> wynik = new List<int>();
                if (liczba1 > liczba2)  // Ustawnienie do zmiennej liczba1 mniejszej z podanych wartosci
                {
                    int temp = liczba2;
                    liczba2 = liczba1;
                    liczba1 = temp;
                }
                for (int i = liczba1; i <= liczba2; i++)
                {
                    if (IsPrime(i))
                        wynik.Add(i);
                }
                Console.WriteLine("liczby pierwsze znajdujące się w zakresie <{0};{1}>", liczba1, liczba2);
                foreach (int item in wynik)
                    Console.Write(item + " ");


            }
            // zadanie3();


            // Zadanie 4
            // Utwórz strukturę losowych osób z losowymi danymi. Zadady:
            // - wiek między 20 a 50 lat
            // - imię 4 literowe zaczynająca się na A.
            // - Nazwisko to odwrócenie imienia.
            // Wylosuj takie 4 osoby i dodaj je do listy Osób. User nic tu nie wprowadza.
            void zadanie4()
            {
                Random r = new Random();
                List<Osoba> listaOsob = new List<Osoba>();
                for (int i = 0; i < 4; i++)
                {
                    Osoba osoba;
                    osoba.imie = "A";
                    for (int j = 1; j < 4; j++)
                    {
                        osoba.imie += (char) r.Next(97, 123);
                    }
                    char[] litery = osoba.imie.ToLower().ToCharArray();
                    litery[3] = char.ToUpper(litery[3]);
                    osoba.nazwisko = "";
                    foreach (char c in litery)
                    {
                        osoba.nazwisko = c + osoba.nazwisko;
                    }

                    // Kod poniżej można użyć zamiast   char[] litery = osoba.imie.ToLower().ToCharArray();
                    //osoba.nazwisko = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(osoba.nazwisko); // zmienia pierwszą literę nazwiska z małej na dużą; Jest potrzebny   using System.Globalization;

                    osoba.wiek = r.Next(20, 51);

                    listaOsob.Add(osoba);
                }
                foreach (Osoba osoba in listaOsob)
                {
                    Console.WriteLine($"{osoba.imie} {osoba.nazwisko}, {osoba.wiek}");
                }
            }
            //zadanie4();

            // Zadanie 5
            // Utwórz kolejkę liczb doskonałych 
            // (liczby które równają się sumie swoich dzielników właściwych). 
            // Umieść w niej 4 najmniejszych liczb doskonałych.
            // Wyświtl kolejkę, usuń z niej 2 liczby i znów wyświtl to co zostało.
            int SumaDzielnikow(int x)
            {
                int suma = 0;
                for (int i = 1; i <= x / 2; i++)
                {
                    if (x % i == 0)
                        suma += i;
                }
                return suma;
            }

            void zadanie5()
            {
                Queue<int> doskonale = new Queue<int>();
                int liczba = 2;
                while (doskonale.Count < 4)
                {
                    if (SumaDzielnikow(liczba) == liczba)
                        doskonale.Enqueue(liczba);
                    liczba += 2;
                }
                Console.Write("Kolejka: ");
                foreach (int item in doskonale)
                    Console.Write(item + " ");
                
                doskonale.Dequeue();
                doskonale.Dequeue();
                Console.Write("\nKolejka po usunięciu 2 liczb: ");
                foreach (int item in doskonale)
                    Console.Write(item + " ");
            }
            //zadanie5();

            // Zadanie 6
            // Stwórz stos nieparzystych dwucyfrowych wieloktorności liczby 13.
            // Usuń z tego stosu 2 liczby i wyświetl znów ten stos dziwiąc się temu co na nim zostało.
            void zadanie6()
            {
                Stack<int> stos = new Stack<int>();
                for (int i = 11; i <= 99; i += 2)
                {
                    if (i % 13 == 0)
                        stos.Push(i);
                }
                Console.Write("Stos: ");
                foreach (int item in stos)
                    Console.Write(item + " ");
                
                stos.Pop();
                stos.Pop();
                Console.Write("\nStos po usunięciu 2 liczb: ");
                foreach (int item in stos)
                    Console.Write(item + " ");
            }
            //zadanie6();

            // Zadanie 7
            // Kod Hufmanna to zamiana ciągu w stylu AAAAABBBBBBBCCC na 5A7B3C.
            // Niech user poda wam n ciągów które zapiszecie to w zwykłej tablicy.
            //Potem przenieście te dane do słowinika, gdzie kluczem będzie kod ciągu a wartością ten ciąg.
            void zadanie7()
            {
                Console.Write("Podaj ilość ciągów: ");
                int n = int.Parse(Console.ReadLine());
                Dictionary<string,string> slownik = new Dictionary<string,string>();
                for (int i = 1; i <= n; i++)
                {
                    Console.Write("\nCiąg numer {0}: ", i);
                    string input = Console.ReadLine();
                    string ciag = input;
                    input += " ";
                    string huffman = "";
                    int ilosc = 1;
                    for (int j = 0; j < input.Length - 1; j++)
                    {
                        if (input[j] == input[j + 1])
                        {
                            ilosc++;
                        }
                        else
                        {
                            if (ilosc > 1)
                                huffman += ilosc.ToString();
                            huffman += input[j];
                            ilosc = 1;
                        }
                    }
                    slownik.Add(huffman, ciag);
                }

                foreach (KeyValuePair<string, string> keyValuePair in slownik)
                {
                    Console.WriteLine("Klucz {0}: {1}", keyValuePair.Key, keyValuePair.Value);
                }
            }
            //zadanie7();

            // Zadanie 8
            // Stwórz graf składający się z 6 wierzchołków i 7 krawędzi. 
            // Wypisz najwyższy stopień wierzchołka. Jeśli kilka wierzchołków ma ten sam stopień to wypisz dowolny z nich.
            void zadanie8()
            {
                int iloscWiersz = 6;
                int iloscKraw = 7;
                Dictionary<int, List<int>> graf = new Dictionary<int, List<int>>();

                for (int i = 1; i <= iloscWiersz; i++)
                {
                    graf.Add(i, new List<int>());
                }

                for (int i = 1; i <= iloscKraw; i++)
                {
                    Console.Write($"Podaj {i} parę liczb (przez spację): ");
                    string[] para = Console.ReadLine().Split();
                    int a = int.Parse(para[0]);
                    int b = int.Parse(para[1]);
                    graf[a].Add(b);
                    graf[b].Add(a);
                }
                int maxStopien = 0;
                int wierszcholek = 1;
                Console.Write("\nGraf: ");
                foreach (KeyValuePair<int, List<int>> item in graf)
                {
                    int stopien = 0;
                    Console.Write("\nWierszchołek {0}: ", item.Key);
                    foreach (int i in item.Value.Distinct())
                    {
                        Console.Write(i + " ");
                        stopien++;
                    }
                    if (stopien > maxStopien)
                    {
                        maxStopien = stopien;
                        wierszcholek = item.Key;
                    }
                }
                Console.WriteLine($"\nWierzchołek {wierszcholek} ma najwyższy stopień: {maxStopien}");

            }
            //zadanie8();
        }
    }
}