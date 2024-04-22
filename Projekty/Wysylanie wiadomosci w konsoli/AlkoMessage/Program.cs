string[] Adresaty = new string[] { "Anna", "Kasia", "Asia", "Malgorzata" };


bool CzyZdolnyDoWyslania()
{
    Random r = new Random();
    int a = r.Next(1, 10);
    int b = r.Next(1, 10);
    int c = r.Next(1, 10);
    string dzialanie = string.Format("{0} + {1} * {2}", a, b, c);
    int wynik = a + b * c;
    Console.WriteLine(dzialanie);
    Console.Write("Podaj wynik: ");
    int odpijaka = int.Parse(Console.ReadLine());
    if (wynik == odpijaka)
    {
        return true;
    }
    return false;
}

void WyswietlFormularzWiadomosci(string[] adresaty)
{
    Console.WriteLine("Wybierz adresata: ");
    for (int i = 0; i < adresaty.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {adresaty[i]}");
    }

    Console.Write("\nWybór: ");
    if (!int.TryParse(Console.ReadLine(), out int adresatNumer))
    {
        Console.WriteLine("Nieprawidłowy format danych. Spróbuj ponownie");
    }
    else
    {
        adresatNumer -= 1;
        if (adresatNumer <= 0 || adresatNumer >= adresaty.Length)
        {
            Console.WriteLine("Podano niepoprawny numer\nNaciśnij dowolny klawisz, aby wrócić do menu głównego");
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Wiadomość do adresata: {0} \nPo napisaniu wiadomości naciśnij [Enter], aby wysłać wiadomość \nJeśli chcesz anulować wysłanie, nic nie pisz", adresaty[adresatNumer]);
            string wiadomosc = Console.ReadLine();
            if (wiadomosc != "")
            {
                Console.Clear();
                Console.WriteLine($"Wysłano wiadomość do adresata: {adresaty[adresatNumer]}\nNaciśnij dowolny klawisz, aby wrócić do menu głównego");
                Console.ReadKey();
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"Anulowano wysłanie wiadomości do adresata: {adresaty[adresatNumer]}\nNaciśnij dowolny klawisz, aby wrócić do menu głównego");
                Console.ReadKey();
            }
        }
    }

    
}

void WyswietlMenu()
{
    Console.WriteLine("1. Napisz");
    Console.WriteLine("2. Rozwiąż");
    Console.WriteLine("[Esc] - Wyjdź");

    Console.Write("\n Wybór: ");

}
bool zdolny = false;
ConsoleKey input;
do
{
    Console.Clear();
    WyswietlMenu();
    input = Console.ReadKey().Key;
    switch (input)
    {
        case ConsoleKey.D1:
            Console.Clear();
            if (zdolny)
            {
                WyswietlFormularzWiadomosci(Adresaty);
            }
            else
            {
                Console.WriteLine("Jeszcze nie udowodniłeś, że jesteś trzeźwyW!");
                Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego");
                Console.ReadKey();
            }
            break;
        case ConsoleKey.D2:
            Console.Clear();
            if (!zdolny)
            {
                if (CzyZdolnyDoWyslania())
                {
                    Console.WriteLine("Udało się, nie jesteś pijany!");
                    zdolny = true;
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Niepoprawnie.\nNaciśnij dowolny klawisz, aby wrócić do menu głównego");
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Już udowodniłeś swoją trzeźwość!");
                Console.WriteLine("\nNaciśnij dowolny klawisz, aby wrócić do menu głównego");
                Console.ReadKey();
            }
            break;
        case ConsoleKey.Escape:
            break;
        default:
            Console.WriteLine("\n Nieprawidłowe dane. Spróbuj ponownie\n");
            Console.ReadKey();
            Console.Clear();
            break;
    }
} while (input != ConsoleKey.Escape);
//Console.WriteLine("Dziękujemy za korzystanie z programu");