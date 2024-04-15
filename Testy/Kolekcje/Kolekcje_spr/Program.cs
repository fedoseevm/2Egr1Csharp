// Zadanie 0
void zadanie0()
{
    string[] input = Console.ReadLine().Split();
    int[] Tab = Array.ConvertAll(input, int.Parse);
    double sr = Tab.Sum() / Tab.Length;
    int licznik = 0;
    foreach (int item in Tab)
    {
        if (item > sr)
            licznik++;
        else if (item < sr)
            licznik--;
    }
    if (licznik > 0)
        Console.WriteLine("Tablica wielkomiejska");
    else if (licznik < 0)
        Console.WriteLine("Tablica małorolna");
    else
        Console.WriteLine("Tablica małomiasteczkowa");

    int[] malomT = new int[4] { 1, 1, 3, 3 };
    Console.Write("\n\nPrzykład tablicy małomiasteczkowej: ");
    foreach (int item in malomT)
        Console.Write(item);

}
//zadanie0();

// Zadanie 1
void zadanie1()
{
    Random r = new Random();
    int[] Table = new int[30];
    Console.WriteLine("Cała tablica: ");
    for (int i = 0; i < Table.Length; i++)
    {
        Table[i] = r.Next(100, 1000);
        Console.Write(Table[i] + " ");
    }

    Dictionary<int,int> ciag = new Dictionary<int, int>();
    Dictionary<int, int> ciagLongest = new Dictionary<int, int>();

   for (int i = 0; i < Table.Length - 1; i++)
    {
        if (Table[i] < Table[i + 1])
        {
            ciag.Add(i, Table[i]);
        }
        else
        {
            ciag.Add(i, Table[i]);
            if (ciag.Count > ciagLongest.Count)
            {
                ciagLongest.Clear();
                int suma = 0;
                foreach (KeyValuePair<int, int> item in ciag)
                {
                    ciagLongest.Add(item.Key, item.Value);
                    suma += item.Value;
                }
            }
            ciag.Clear();
        }
    }
    Console.WriteLine("\nSuma: {0}", ciagLongest.Values.Sum());
    Console.WriteLine("Element początkowy: {0} \nKońcowy: {1}", ciagLongest.First().Value, ciagLongest.Last().Value);
}
//zadanie1();

// Zadanie 2
void zadanie2()
{
    Random r = new Random();
    List<int> L1 = new List<int>();
    List<int> L2 = new List<int>();
    Console.WriteLine("Lista 1");
    while (L1.Count != 6)
    {
        int cyfra = r.Next(0, 10);
        if (!L1.Contains(cyfra))
        {
            L1.Add(cyfra);
            Console.Write(cyfra + " ");
        }
    }

    Console.WriteLine("\n\nLista 2");
    int licznik = 0;
    while (L2.Count != 6)
    {
        int cyfra = r.Next(0, 10);
        if (licznik < 3)
        {
            if (!L2.Contains(cyfra))
            {
                L2.Add(cyfra);
                Console.Write(cyfra + " ");
                licznik++;
            }
        }
        else
        {
            if (L2.Contains(cyfra))
            {
                L2.Add(cyfra);
                Console.Write(cyfra + " ");
            }
        }
    }

    List<int> wynik = new List<int>();
    for (int cyfra = 0; cyfra < 10; cyfra++)
    {
        int counter = 0;
        foreach (int item in L1)
        {
            if (cyfra == item)
                counter++;
        }
        foreach (int item in L2)
        {
            if (cyfra == item)
                counter++;
        }

        if (counter == 2)
        {
            wynik.Add(cyfra);
        }
        if (counter > 2)
        {
            wynik.Add(cyfra);
            wynik.Add(cyfra);
        }
    }

    Console.WriteLine("\n\nWynikowa: ");
    foreach (int item in wynik)
        Console.Write(item + " ");
}

zadanie2();