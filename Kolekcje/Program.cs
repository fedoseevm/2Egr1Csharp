using System.Collections;


// Zadanie 1
// Stworz tablice 115 pierwszych liczb, ktore w reprezentacji binarnej koncza sie na dwie 1
// 11, 111, 1011, 1111, 10011, 101011 ...
Console.WriteLine("Zadanie 1");
int[] Tablica11 = new int[115];
Tablica11[0] = 3;
for (int i = 1; i < Tablica11.Length; i++)
{
    Tablica11[i] = Tablica11[i - 1] + 4;
}
foreach (int number in Tablica11)
    Console.Write(number + " ");
Console.WriteLine("\n");

// Zadanie 2
// Stworzyc plik o nazwie osoby z zawartoscia 5 osob:
// imie, nazwisko, wiek
// Bartosz, Nowak, 43
// Pawel, Kowal, 21
// Krystyna, Zrybnika, 27
// i wstawic obiekty (struktury) typu osoba z wlasciwosciami / polami z pliku, czyli imie, nazwisko, wiek

Console.WriteLine("Zadanie 2");
// STRUKTURA
Osoba[] os = new Osoba[5];

StreamReader sr = new StreamReader("../../../Osoby.txt");

string[] S = new string[3];
int k = 0;
while (!sr.EndOfStream)
{
    S = sr.ReadLine().Split(';');
    Osoba osoba;
    osoba.imie = S[0];
    osoba.nazwisko = S[1];
    osoba.wiek = int.Parse(S[2]);
    os[k] = osoba;
    k++;
}

foreach (var item in os)
{
    Console.WriteLine($"{item.imie} {item.nazwisko} {item.wiek}");
}
Console.WriteLine("\n");


// Zadanie 3
// Stworz liste 6 losowych 3-znakowych slow skladajacych sie z roznych samoglosek
Console.WriteLine("Zadanie 3");
Random r = new Random();
List<string> Slowa = new List<string>();
char[] Samogloski = new char[] { 'a', 'ą', 'e', 'ę', 'i', 'o', 'ó', 'u', 'y' };
List<char> Chars;
string slowo;
int numer;
for (int i = 0; i < 6; i++)
{
    slowo = "";
    Chars = Samogloski.ToList();
    for (int j = 0; j < 3; j++)
    {
        numer = r.Next(0, Chars.Count());
        slowo += Chars[numer];
        Chars.RemoveAt(numer);
    }
    Slowa.Add(slowo);
}

// WERSJA 2
// NIE DZIALA (nwm dlaczego)
/*
string slowo;
int numer;
for (int i = 0; i < 6; i++)
{
    slowo = "";
    for (int j = 0; j < 3; j++)
    {
        numer = r.Next(0, Samogloski.Length);
        if (!Samogloski.Contains(Samogloski[numer]))
            slowo += Samogloski[numer];
        else
            j--;
    }
    Slowa.Add(slowo);
}
*/
foreach (var item in Slowa)
{
    Console.WriteLine(item);
}
Console.WriteLine("\n");

// Zadanie 4 QUEUE - kolejka
// Stworz kolejke 4 losowych liczb fibonacciego (moga sie powtarzac).
// Wyswietl kolejke, Usun z niej 2 elementy i wyswietl pozostale 2.

//using System.Collections;
// Random r = new Random();
Console.WriteLine("Zadanie 4");
List<int> Fib = new List<int>() { 0, 1 };

int x = 2;
while ((Fib[x - 1] + Fib[x - 2]) < 100) // Wypelnienie listy ciagiem Fibonacciego
{
    Fib.Add(Fib[x - 1] + Fib[x - 2]);
    x++;
}

Queue q = new Queue();  // Tworzenie kolejki Queue
for (int j = 0; j < 5; j++)
{
    q.Enqueue(Fib.ElementAt(r.Next(0, Fib.Count()))); // Dokladanie nowych elementow na koniec kolejki
}
Console.WriteLine("Perwsza kolejka:");  // Wypisywanie elementow kolejki
foreach (var item in q)
{
    Console.Write(item + " ");
}
Console.WriteLine("\n");
q.Dequeue(); // Usuwa pierwszy element kolejki
q.Dequeue();

Console.WriteLine("Druga kolejka po usunieciu 2 elementow:");
foreach (var item in q)
{
    Console.Write(item + " ");
}


// Zadanie 5 STACK Stos
// Stworz stos 5 najwiekszych trzycyfrowych liczb pierwszych.
// Wyswietl stos, usun 3 wyrazy i zwow wyswietl stos.

Console.WriteLine("\n\nZadanie 5");
bool ifPrime(int x)
{
    for (int i = 2; i < Math.Sqrt(x) + 1; i++)
        if (x % i == 0)
            return false;
    return true;
}

List<int> PrimeNumbers = new List<int>();
for (int i = 999; PrimeNumbers.Count < 10; i -= 2)  // Wypelnienie listy PrimeNumbers liczbami perwszymi dwucyfrowymi
{
    if (ifPrime(i))
        PrimeNumbers.Add(i);
    // Jesli nie wiadomo, czy bedzie wystarzajaco elementow dodano do listy PrimeNumbers (musi buc 10)
    //if (PrimeNumbers.Count == 10) 
    //    break;
}

Stack stos = new Stack();   // LIFO - Last In First Out 
//stos.Push();  - dodanie elementa do stosu
//stos.Pop();   - usuwanie ostatniego elementu ze stosu
foreach (var item in PrimeNumbers)
{
    Console.Write(item + " ");
    stos.Push(item);
}
Console.WriteLine("\n");
foreach (var item in stos) // Wypisywanie stosu. UWAGA: wypisuje elementy w przeciwna strone.
{
    Console.Write(item + " ");
}

// Zadanie 6
// Slowniki
// Stworz prosty graf 1 => 2, 3; 2 => 3; 3 => 1, 2, 5; 4 => null; 5 => 3
Console.WriteLine("\n\nZadanie 6");
Dictionary<int, List<int>> D = new Dictionary<int, List<int>>();

Console.Write("Ilosc wierzcholkow: ");
int vertNumber = int.Parse(Console.ReadLine());

for (int i = 1; i <= vertNumber; i++)
{
    D.Add(i, new List<int>());
}

Console.Write("Ilosc par: ");
int pairNumber = int.Parse(Console.ReadLine());
string[] Liczby;
int a, b;
for (int i = 0; i < pairNumber; i++)
{
    Liczby = Console.ReadLine().Split();
    a = int.Parse(Liczby[0]);
    b = int.Parse(Liczby[1]);
    D[a].Add(b);
    D[b].Add(a);
}
Console.WriteLine("\n");

Console.WriteLine($"Graf z {vertNumber} wierzcholkow i {pairNumber} polaczen: ");
foreach (KeyValuePair<int, List<int>> item in D)
{
    Console.Write(item.Key + ": ");
    foreach (var value in item.Value)
        Console.Write(value + " ");
    Console.WriteLine();
}


struct Osoba
{
    public string imie;
    public string nazwisko;
    public int wiek;
}