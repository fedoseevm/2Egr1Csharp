// Algorytmy

Random R = new Random();
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int temp;

// Napisz i przetestuj algorytm Euklidesa odejmowanie
while (a != b)
{
    if (a > b) a -= b;
    if (b > a) b -= a;
}
Console.WriteLine(a);
Console.WriteLine("\n");
int EuklidesOdejmowanie(int a, int b)
{
    while (a != b)
    {
        if (a > b) a -= b;
        if (b > a) b -= a;
    }
    return a;
}
Console.WriteLine(EuklidesOdejmowanie(a, b));
Console.WriteLine("\n");

// Napisz i przetestuj algorytm Euklidesa modulo
int EuklidesModulo(int a, int b)
{
    while (b > 0)
    {
        temp = a;
        a = b;
        b = temp % b;
    }
    return a;
}
Console.WriteLine(EuklidesModulo(a, b));
Console.WriteLine("\n");

// Napisz i prezentuj algorytm sortowania babelkowego na tablicy
int n = int.Parse(Console.ReadLine());
int[] TabLosowa = new int[n];
for (int i = 0; i < n; i++)
{
    TabLosowa[i] = R.Next(0, 9);
    Console.Write(TabLosowa[i] + " ");
}
Console.WriteLine("\n");

int[] SortBubble(int[] T)
{
    int temp;
    for (int i = n - 1; i >= 0; i--)
        for (int j = 0; j < i; j++)
        {
            if (T[j + 1] < T[j])
            {
                temp = T[j];
                T[j] = T[j + 1];
                T[j + 1] = temp;
            }
        }
    return T;
}
foreach (int cyfra in SortBubble(TabLosowa))
    Console.Write(cyfra + " ");


// Wypisz wszystkie pary liczb zaprzyjaznionych z przedzialu 1 - 10.000

int suma_dzielnikow(int a)
{
    int suma = 0;
    for (int i = 1; i <= a / 2; i++)
        if (a % i == 0)
            suma += i;
    return suma;
}

int pom;
for (int i = 1; i <= 10000; i++)
{
    pom = suma_dzielnikow(i);
    if (i == suma_dzielnikow(pom) && i != pom)
        Console.WriteLine(i + " " + pom);
}


// Listy - Tablice - w tablicy 30 lisczb losowych trzycyfrowych
int[] TabLosowychTrzycyfr = new int[30];
for (int i = 0; i < TabLosowychTrzycyfr.Length; i++)
{
    TabLosowychTrzycyfr[i] = R.Next(100, 1000);
    Console.Write(TabLosowychTrzycyfr[i] + " ");
}
Console.WriteLine("\n");

// znajdz ilosc wielokrotnosci liczby 17 (zapisz te liczby do listy wynikowej)
List<int> wynik = new List<int>();
for (int i = 0; i < TabLosowychTrzycyfr.Length; i++)
{
    if (TabLosowychTrzycyfr[i] % 17 == 0)
        wynik.Add(TabLosowychTrzycyfr[i]);
}
foreach (int liczba in wynik)
    Console.Write(liczba + " ");

// Macierz cyfr - wypisz sumy kolejnych ramek w macierzy kwadratowej o n parzystym
int n = R.Next(1, 6) * 2;
int[,] MacierzMain = new int[n, n];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        MacierzMain[i, j] = R.Next(0, 10);
        Console.Write(MacierzMain[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("\n");

List<int> MacierzSuma = new List<int>();
List<int> wynikRamka = new List<int>();
int odstep = 0;
while (odstep <= n / 2)
{
    int suma = 0;
    for (int i = 0 + odstep; i < n - odstep; i++)
    {
        for (int j = 0 + odstep; j < n - odstep; j++)
        {
            suma += MacierzMain[i, j];
        }
    }
    MacierzSuma.Add(suma);
    odstep++;

}
for (int i = 0; i < MacierzSuma.Count - 1; i++)
{
    wynikRamka.Add(MacierzSuma[i] - MacierzSuma[i + 1]);
}

Console.WriteLine("\n");
foreach (int liczba in wynikRamka)
    Console.Write(liczba + " ");
