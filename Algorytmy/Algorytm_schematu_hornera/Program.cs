// Algorytm schematu Hormera
// Wejscie: system, liczba
// Wyjscie: liczba w systemie dziesietnym

int horner(int system_licby, string liczba)
{
    int wynik = (int)char.GetNumericValue(liczba[0]);
    for (int i = 1; i < liczba.Length; i++)
    {
        wynik = system_licby * wynik + (int)char.GetNumericValue(liczba[i]);
    }
    return wynik;
}

int system_liczby = int.Parse(Console.ReadLine());
string liczba = Console.ReadLine();
Console.WriteLine(horner(system_liczby, liczba));


// konwersja bin -> dec
double bin2dec(string bin)
{
    double wynik = 0;
    for (int i = bin.Length - 1; i >= 0; i--)
    {
        wynik += Math.Pow(2, bin.Length - i - 1) * (int)char.GetNumericValue(bin[i]);
    }
    return wynik;
}
string bin = Console.ReadLine();
Console.WriteLine(bin2dec(bin));


// konwersja dec -> bin
string dec2bin(int dec)
{
    string wynik = "";
    string reszta;
    while (dec > 0)
    {
        reszta = Convert.ToString(dec % 2);
        wynik += new string(reszta);
        dec /= 2;
    }
    return wynik;
}


int dec = int.Parse(Console.ReadLine());
Console.WriteLine(dec2bin(dec));