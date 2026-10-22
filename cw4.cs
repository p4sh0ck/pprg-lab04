int LiczbaTur;

while (true)
{
    Console.Write("Podaj liczbę tur od 1 do 10: ");
    bool liczbaCalkowita = int.TryParse(Console.ReadLine(), out LiczbaTur);

    if (!liczbaCalkowita)
    {
        Console.WriteLine("Wpisz liczbę całkowitą.");
        continue;
    }

    if (LiczbaTur < 1 || LiczbaTur > 10)
    {
        Console.WriteLine("Liczba musi należeć do zakresu 1-10.");
        continue;
    }

    break;
}

Console.WriteLine($"Rozpoczynam grę na {LiczbaTur} tur.");