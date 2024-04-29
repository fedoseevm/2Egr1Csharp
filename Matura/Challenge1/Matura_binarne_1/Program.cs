List<string> PobranaLista()
{
    StreamReader sr = new StreamReader("../../../anagram.txt");
    List<string> binarne = new List<string>();
    while (!sr.EndOfStream)
    {
        binarne.Add(sr.ReadLine());
    }
    return binarne;
}

// 3.1
void zadanie31()
{
    List<string> binarne = PobranaLista();

    int iloscZrownowazonych = 0;
    int iloscPrawieZrownowazonych = 0;
    for (int i = 0; i < binarne.Count; i++)
    {
        int roznica = 0;
        for (int j = 0; j < binarne[i].Length; j++)
        {
            if (binarne[i][j] == '1')
                roznica++;
            else 
                roznica--;
        }
        if (roznica == 0)
            iloscZrownowazonych++;
        if (roznica == 1 || roznica == -1)
            iloscPrawieZrownowazonych++;
    }
    Console.WriteLine("Ilosc liczb zrównoważonych: {0}", iloscZrownowazonych);
    Console.WriteLine("Ilosc liczb prawie zrównoważonych: {0}", iloscPrawieZrownowazonych);
}
//zadanie31();

// 3.2
void zadanie32()
{
    List<string> binarne = PobranaLista();
    List<string> wynik = new List<string>();

    foreach (string binarna in binarne)
    {
        if (binarna.Length == 8)
        {
            int liczba_0 = 0;
            for (int i = 1; i < binarna.Length; i++)
            {
                if (binarna[i] == '0')
                {
                    liczba_0++;
                }
            }
            if (liczba_0 == binarna.Length || liczba_0 == binarna.Length - 1)
            {
                wynik.Add(binarna);
            }
        }
    }
}
zadanie32();