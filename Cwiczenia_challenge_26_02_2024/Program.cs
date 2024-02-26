using System.Collections;


// Zadanie 1
// Stworz tablice 115 pierwszych liczb, ktore w reprezentacji binarner koncza sie na dwie 1
// 11, 111, 1011, 101011 ...
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

// Zadanie 4 KOLEKLA
// Stworz kolejke 4 losowych liczb fibonacciego (moga sie powtarzac).
// Wyswietl kolejke, Usun z niej 2 elementy i wyswietl pozostale 2.

//using System.Collections;
// Random r = new Random();
List<int> Fib = new List<int>() { 1, 2 };
//Fib.Add(1);
//Fib.Add(2);

int x = 2;
while ((Fib[x - 1] + Fib[x - 2]) < 100)
{
    Fib[x] = Fib[x - 1] + Fib[x - 2];
    x++;
}

// Dokonczyc
Queue q = new Queue();
for (int j = 0; j < 4; j++)
{
    q.Enqueue(Fib.ElementAt(r.Next(0, Fib.Count()))); 
}
foreach (var item in q)
{
    Console.WriteLine(item);
}
Console.WriteLine();
q.Dequeue();
q.Dequeue();
foreach (var item in q)
{
    Console.WriteLine(item);
}


// Zadanie 5 STOS
// Stworz stos 5 kolejnych dwucyfrowych liczb pierwszych.
// Wyswietl stos, usun 3 wyrazy i zwow wyswietl stos.



struct Osoba
{
    public string imie;
    public string nazwisko;
    public int wiek;
}