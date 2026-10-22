int zdrowieBohatera = 60;
int zdrowiePrzeciwnika = 45;
int liczbaMikstur = 2;
int numerTury = 1;
bool graDziala = true;

while (graDziala && zdrowieBohatera > 0 && zdrowiePrzeciwnika > 0)
    {
        Console.WriteLine();
        Console.WriteLine($"=== TURA {numerTury} ===");
        Console.WriteLine($"Zdrowie: {zdrowieBohatera} | Mikstury: {liczbaMikstur}");
        Console.WriteLine($"Zdrowie przeciwnika: {zdrowiePrzeciwnika}");
        Console.WriteLine("1 - Atak");
        Console.WriteLine("2 - Mikstura");
        Console.WriteLine("3 - Ucieczka");
        Console.Write("Akcja: ");

        string akcja = Console.ReadLine()!;

        switch (akcja)
        {
            case "1":
                zdrowieBohatera -= 7;
                zdrowiePrzeciwnika -= 12;
                Console.WriteLine("Zadajez przeciwnikowi 12 punktów obrażeń, natomiast jego atak zadaje ci 7 punktów obrażeń");
                break;
            case "2":
                zdrowieBohatera += 15;
                liczbaMikstur -= 1;
                Console.WriteLine("Odzyskujesz 15 punktów życia.");
                break;
            case "3":
                graDziala = false;
                Console.WriteLine("Uciekzasz z pola bitwy.");
                break;
            default:
                Console.WriteLine("Nieznana akcja.");
                continue;
        }

        numerTury++;
    }

    if (zdrowieBohatera <= 0)
    {
        Console.WriteLine("Bohater został zabity.");
    }
    else if (zdrowiePrzeciwnika <= 0)
    {
        Console.WriteLine("Przeciwnik został pokonany!");
    }
