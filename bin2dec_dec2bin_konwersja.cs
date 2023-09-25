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
