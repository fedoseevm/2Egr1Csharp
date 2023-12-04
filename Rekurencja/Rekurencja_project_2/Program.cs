// Zadanie 1
Console.WriteLine("Zadanie 1");
int n = 12;
// a) 2 3 4 -1 -8 -11 -2
Console.WriteLine("a)");
int reku1a(int n)
{
    if (n == 1) return 2;
    if (n == 2) return 3;
    if (n == 3) return 4;
    return -1 * (reku1a(n - 3) + reku1a(n - 2)) + reku1a(n - 1);
}
for (int i = 1; i <= n; i++)
{
    Console.Write(reku1a(i) + " ");
}
Console.WriteLine("\n");

// 1 4 3 16 5 64 7 256 9 1024
Console.WriteLine("b)");
int reku1b(int n)
{
    if (n == 1) return 1;
    if (n == 2) return 4;
    else if (n % 2 == 1) return reku1b(n - 2) + 2;
    else return reku1b(n - 2) * 4;
}
for (int i = 1; i <= n; i++)
{
    Console.Write(reku1b(i) + " ");
}


// Zadanie 2
Console.WriteLine("\n\nZadanie 2");
// Wyznacz sumę cyfr wpisaniej przez usera liczby
int x = int.Parse(Console.ReadLine());
int suma = 0;

// iter 
int temp = x;
while (temp > 0)
{
    suma += temp % 10;
    temp /= 10;
}
Console.WriteLine(suma);

// reku
int rekuSumaCyfr(int x)
{
    if (x == 0) return 0;
    return rekuSumaCyfr(x / 10) + (x % 10);
}
Console.WriteLine(rekuSumaCyfr(x));


// Zadanie 3
Console.WriteLine("\n\nZadanie 3");
// zamiana DEC -> BIN
// iter
int liczbaDec = int.Parse(Console.ReadLine());
string dec2bin(int liczbaDec)
{
    string liczbaBin = "";
    while (liczbaDec > 0)
    {
        liczbaBin = liczbaDec % 2 + liczbaBin;
        liczbaDec /= 2;
    }
    return liczbaBin;
}
Console.WriteLine(dec2bin(liczbaDec));


// reku
string reku_dec2bin(int x)
{
    if (x == 0) return "";
    return reku_dec2bin(x / 2) + (x % 2).ToString();
}
Console.WriteLine(reku_dec2bin(liczbaDec));



// Zadanie Korale
// 0 - koraliki biale
// 1 - koraliki czarne

string KoraleBis(int x)
{
    string liczbaBin = "";
    while (liczbaDec > 0)
    {
        liczbaBin = liczbaDec % 2 + liczbaBin;
        liczbaDec /= 2;
    }
    return liczbaBin;
}
Console.WriteLine(KoraleBis(15));