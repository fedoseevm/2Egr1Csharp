

int nwd(int a, int b)
{
    int temp;
    while (b != 0)
    {
        temp = a;
        a = b;
        b = temp % b;
    }
    return a;
}
int nww(int a, int b)
{
    return (a * b) / nwd(a, b);
}


// PIERWSZA DYSZKA
// 1. User podaje NWD i NWW dwóch liczb. Napisz program, który znajdzie te liczby.
void liczby_nww_nwd()
{
    // a * b = nwd * nww
    int nwd_liczba = int.Parse(Console.ReadLine());
    int nww_liczba = int.Parse(Console.ReadLine());
    int iloczyn = nwd_liczba * nww_liczba;
    int pierwsza, druga;
    for (int i = 2; i <= iloczyn / 2; i++)
    {
        if (iloczyn % i == 0)
        {
            pierwsza = i;
            druga = iloczyn / i;
            if (nwd(pierwsza, druga) == nwd_liczba && nww(pierwsza, druga) == nww_liczba && pierwsza >= druga)
                Console.WriteLine(pierwsza + " " + druga);
        }
    }
}
// liczby_nww_nwd();

// 2. Sprawdź czy suma dwóch ułamków podanych przez usera jest ułamkiem niewłaściwym.

string czy_ulamki_niewl()
{
    int l1 = int.Parse(Console.ReadLine());
    Console.WriteLine("/");
    int m1 = int.Parse(Console.ReadLine());
    Console.WriteLine("+");
    int l2 = int.Parse(Console.ReadLine());
    Console.WriteLine("/");
    int m2 = int.Parse(Console.ReadLine());
    int nww = (l1 * l2) / nwd(m1, m2);
    int wynik = l1 * nww / m1 + l2 * nww / m2;
    if (wynik > nww)    return "Ulamek niewlasciwy";
    else                return "Nie jest ulamkiem niewlasciwym";
}
// Console.WriteLine(czy_ulamki_niewl());

// 3. Sprawdź czy wieksza jest suma dwóch wpisanych przez usera ułamków czy suma ich odwrotności.
string ulamek_czy_odwr()
{
    int l1 = int.Parse(Console.ReadLine());
    Console.WriteLine("/");
    int m1 = int.Parse(Console.ReadLine());
    Console.WriteLine("+");
    int l2 = int.Parse(Console.ReadLine());
    Console.WriteLine("/");
    int m2 = int.Parse(Console.ReadLine());
    //================
    int nww_ulamka = (l1 * l2) / nwd(m1, m2);
    int licznik_ulamka = l1 * nww_ulamka / m1 + l2 * nww_ulamka / m2;
    //----------------
    int nww_odwr = (m1 * m2) / nwd(l1, l2);
    int licznik_odwr = m1 * nww_odwr / l1 + m2 * nww_odwr / l2;
    //================
    if (licznik_ulamka / nww_ulamka > licznik_odwr / nww_odwr)
        return "suma dwóch wpisanych przez usera ułamków jest wieksza od ich odwrotności";
    else
        return "Odwrotnosc jest wieksza";
}
// Console.WriteLine(ulamek_czy_odwr());

// 4. Sprawdź czy w danym napisie więcej jest spółgłosek czy samogłosek.
// chr() and ord() from Python
/*
char chr(int x)
{
    return (char)x;
}
int ord(char c)
{
    return (int) c;
}
*/

string spolglosek_czy_samoglosek()
{
    string napis = Console.ReadLine();
    napis = napis.ToUpper();
    int ilosc_spolglosek = 0;
    int ilosc_samoglosek = 0;
    char[] literki = napis.ToCharArray();
    List<int> samogloski = new List<int>() { 65, 69, 73, 79, 85};
    foreach (char c in literki)
    {
        if (samogloski.Contains((int)c))
            ilosc_samoglosek++;
        else
            ilosc_spolglosek++;
    }
    if (ilosc_spolglosek > ilosc_samoglosek)
        return "Wiecej spolglosek";
    else if (ilosc_spolglosek == ilosc_samoglosek)
        return "Ilosc spolglosek i samoglosek jest rowna";
    else
        return "Wiecej samoglosek";
}
// Console.WriteLine(spolglosek_czy_samoglosek());

// 5. Podaj której literki jest najwięcej w podanym napisie i jaka to jest literka.
void najwiecej_liter()
{
    string napis = Console.ReadLine();
    napis = napis.ToUpper();
    char[] literki = napis.ToCharArray();
    int[] ints = new int[100];
    foreach (char c in literki)
        ints[c]++;
    Console.WriteLine(literki[ints.Max()]); 
}
// najwiecej_liter();

// 6. Znajdź trzy takie liczby, których suma, a także suma każdej pary tych liczb jest kwadratem innej liczby calkowitej.
// 80 320 41

// 7. Dwie wieżyce, jedna wysokości 30 stóp, druga 40 stóp, oddalone są od siebie o 50 stóp. 
//  Pomiędzy nimi znajduje się wodotrysk, do którego zlatują dwa ptaki z wierzchołków obu wieżyc 
//  i lecąc z jednakową prędkością przybywają w tym samym czasie. 
//  Napisz program, który obliczy jest dłuższa odległość pozioma wodotrysku jednej z wieżyc?
