string[] parsujBaze()
{
    string[] strings = new string[1];
    string danePlik = "";
    using (StreamReader sr = new StreamReader(@"..\..\..\..\baza.txt"))
        while (!sr.EndOfStream)
        {
            danePlik = sr.ReadLine();
        }
    if (danePlik != null)
        return danePlik.Split(',');
    else
        return new string[] { "nie" };
}
foreach (string s in parsujBaze())
    Console.WriteLine(s);


bool logowanie(string[] data)
{
    Console.Write("Podaj login: ");
    string login = Console.ReadLine();
    Console.Write("Podaj haslo: ");
    string haslo = Console.ReadLine();
    if (login == data[0] && haslo == data[1])
    {
        Console.WriteLine("Gotowy na test trzezwosci? [Y/N]: ");    // ???????????????
        if (Console.ReadKey().Key == ConsoleKey.Y)
            return true;
        else
            return false;
    }

    else
    {
        Console.WriteLine("nieprawidlowe login lub haslo");
        return false;
    }
}


Console.WriteLine(logowanie(parsujBaze()));