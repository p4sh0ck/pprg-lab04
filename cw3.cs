Console.Write("Podaj wysokość choinki (2-10): ");
int wysokosc = int.Parse(Console.ReadLine());

for (int wiersz = 1; wiersz <= wysokosc; wiersz++)
{
    for (int spacja = 1; spacja <= wysokosc - wiersz; spacja++)
    {
        Console.Write(" ");
    }

    for (int gwiazdka = 1; gwiazdka <= 2 * wiersz - 1; gwiazdka++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}

for (int spacja = 1; spacja < wysokosc; spacja++)
{
    Console.Write(" ");
}

Console.WriteLine("*");
