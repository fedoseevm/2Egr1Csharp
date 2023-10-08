// Algorytm schematu Hormera
// Wejscie: system, liczba
// Wyjscie: liczba w systemie dziesietnym

int horner(int system_liczby, string liczba)
{
    int wynik = (int)char.GetNumericValue(liczba[0]);
    for (int i = 1; i < liczba.Length; i++)
    {
        wynik = system_liczby * wynik + (int)char.GetNumericValue(liczba[i]);
    }
    return wynik;
}

int system_liczby = int.Parse(Console.ReadLine());
string liczba = Console.ReadLine();
Console.WriteLine(horner(system_liczby, liczba));
