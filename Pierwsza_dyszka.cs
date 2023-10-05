

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
void dwie_wiezyce()
{
    int h1 = 30;
    int h2 = 40;
    int odleglosc = 50;
    double a;
    Console.WriteLine("Droga pokonana przez ptaka z wiezy 30 stop - S1, a przez drugiego z wysokosci 40 stop - S2");
    Console.WriteLine("S1 = S2     dlatego, ze ptaki pokonali swoje drogi z jednakowa predkoscia w tym samym czasie");
    Console.WriteLine("S1^2 = 30^2 + a^2");
    Console.Write("S2^2 = 40^2 + (50 - a)^2");
    Console.WriteLine("\n");
    Console.WriteLine("30^2 + a^2 = 40^2 + (50 - a)^2");
    Console.WriteLine("a^2 = 40^2 + 50^2 - 100*a + a^2 - 30^2");
    Console.WriteLine("100 * a = 40^2 + 50^2 - 30^2");
    Console.Write("a = (40^2 + 50^2 - 30^2) / 100");
    Console.WriteLine("\n");
    a = (Math.Pow(40, 2) + Math.Pow(50, 2) - Math.Pow(30, 2)) / 100;
    Console.WriteLine("a = {0}", a);
    Console.WriteLine("b = {0}", 50 - a);
}
// dwie_wiezyce();

// 8. Brajanek z Dżesiką grają w siedem. Gra polega na tym, że jeden z graczy podaje granice przedziału <a, b> 
// a drugi z nich musi szybko odpowiedzieć, ile w tym przedziale jest liczb,
// które są podzielne przez siedem, albo suma ich cyfr jest podzielna przez siedem (lub jedno i drugie). 
// Napisz program, który pomaga w takich obliczeniach.
int suma_cyfr(int n)
{
    int suma = 0;
    while (n > 0)
    {
        suma += n % 10;
        n /= 10;
    }
    return suma;
}

int siedem()
{
    int wynik = 0;
    int poczatek = int.Parse(Console.ReadLine());
    int koniec = int.Parse(Console.ReadLine());
    for (int i = poczatek; i <= koniec; i++)
    {
        if (i % 7 == 0 || suma_cyfr(i) % 7 == 0)
            wynik++;
    }
    return wynik;
}
// Console.WriteLine(siedem());

// 9. Halinka wspina się na schody w centrum handlowym. Za każdym razem, gdy dziewczynka wspina się na nowe schody,
// zaczyna liczyć na głos po kolei od 1 do ilości stopni. Na przykład,
// jeśli wspina się na dwa zestawy schodów – jeden z 3 stopniami, a drugi z 4 stopniami – 
// będzie liczyć tak: 1, 2, 3, 1, 2, 3, 4.Masz dane wszystkie liczby, które Halinka wypowiedziała 
// podczas całej swojej wycieczki po centrum i Twoim zadaniem jest obliczenie, ile zestawów schodów „zaliczyła”.
int policz_schody()
{
    int wynik = 0;
    List<int> liczenie_szchodow = new List<int>() { 1, 2, 3, 1, 2, 3, 4, 1, 2, 3, 4, 5, 1, 2 };
    foreach (int liczba in liczenie_szchodow)
        if (liczba == 1)
            wynik++;
    return wynik;
}
// Console.WriteLine("Halinka zaliczyła {0} zestawow schowow", policz_schody());

// 10.Brajanek wybrał się na spacer do parku. Przysiadł na chwilę na parkowej ławce i obserwował
// przechadzających się ludzi.
// W parku znajduje się n ławek ponumerowanych od 1 do n. Kiedy Brajanek zaczął swoje
// obserwacje, na i-tej ławce siedziało ai osób. Do parku przybyło właśnie m osób i każda chciałaby
// znaleźć sobie miejsce na ławce.
// Niech k oznacza największą liczbę osób siedzących na jednej ławce (po przyjściu tych dodatkowych m osób). 
// Jaka jest minimalna, a jaka maksymalna wartość k?

// Ławki (przyklad)
//  1:  4 osoby
//  2:  6 osób
//  3:  2 osoby
void lawki()
{
    int k_max = 0;
    Console.Write("Podaj ilosc lawek: ");
    int n = int.Parse(Console.ReadLine());
    List<int> osoby_na_lawce = new List<int>();
    for (int i = 1; i <= n; i++)
    {
        Console.Write("Lawka {0}: ", i);
        osoby_na_lawce.Add(int.Parse(Console.ReadLine()));
        k_max += osoby_na_lawce[i - 1];
    }
    Console.Write("Ile osob przybylo: ");
    int m = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("k max: {0}", k_max);
    Console.WriteLine("k min: {0}", Math.Floor((decimal)((k_max + m) / n)));
}
// lawki();
