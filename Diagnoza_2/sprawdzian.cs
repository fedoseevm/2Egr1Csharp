// Zad -1
bool czy_p(int n)
{
    for (int i = 2; i < Math.Sqrt(n) + 1; i++)
    {
        if (n % i == 0)
            return false;
    }
    return true;
}
int liczba = int.Parse(Console.ReadLine());
if (czy_p(liczba) && czy_p(2 * liczba + 1))
    Console.WriteLine("Liczba Ibrahima");
else
    Console.WriteLine("Nie jest liczbą Ibrahima");
Console.WriteLine("\n");

// Zad 0
for (int i = 2; i <= 100; i++)
{
    if (czy_p(i) && czy_p(2 * i + 1))
        Console.Write(i + " ");
}
Console.WriteLine("\n");

// Zad 1
Random r = new Random();
int n = int.Parse(Console.ReadLine());
int[,] M = new int[n, n];
for (int i = 0; i < M.GetLength(0); i++)
{
    for (int j = 0; j < M.GetLength(1); j++)
    {
        int l = r.Next(0, 9);
        if (l == 0 || l == 1 || l == 2 || l == 3 || l == 4)
            M[i, j] = 0;
        if (l == 5 || l == 6)
            M[i, j] = 1;
        if (l == 7 || l == 8)
            M[i, j] = 2;
        if (j == 9)
            M[i, j] = r.Next(3, 4);
        Console.Write(M[i, j]);
    }
    Console.WriteLine();
}

int k = 0;
for (int i = 0; i < M.GetLength(0); i++)
{
    for (int j = 0; j < M.GetLength(1); j++)
    {
        if (i == 0)
        {
            if (j == 0)
                if (M[i, j] == M[i, j + 1] + M[i + 1, j + 1] + M[i + 1, j])
                    k++;
                else if ()
                    if (M[i, j] == M[i - 1, j] + M[i - 1, j + 1] + M[i, j + 1] + M[i + 1, j + 1] + M[i + 1, j])
                        k++;
        }
    }
}
Console.WriteLine("\n");

// Zad 2
string ciag = Console.ReadLine();
char[] cyfry = ciag.ToCharArray();
int[] ints = new int[9];
for (int i = 0; i < 40; i++)
{
    ints[Convert.ToInt16(cyfry[i])]++;
}
Console.WriteLine(ints.Max());


// Zad 3
int n = int.Parse(Console.ReadLine());
List<int> wynik = new List<int>();
bool fenenn = false;
int a = 5;
while (wynik.Count <= 3 && fenenn == true)
{
    a += 2;
    for (int i = 0; i < n; i++)
    {
        if (czy_p(i) && i % 2 == 1)
        {
            wynik.Add(i);
        }
    }
    if (wynik[0] + wynik[1] + wynik[2] == n)
        fenenn = true;
}
