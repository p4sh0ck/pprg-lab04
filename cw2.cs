Console.Write("Podaj liczbę dni wyprawy (1-7): ");
int liczbaDni = int.Parse(Console.ReadLine());

int sumaZlota = 0;
int liczbaUdanychDni = 0;

for (int dzien = 1; dzien <= liczbaDni; dzien++)
{
	Console.Write($"Dzień {dzien} - podaj liczbę znalezionych sztuk złota: ");
    int znalezioneZloto = int.Parse(Console.ReadLine());

	sumaZlota += znalezioneZloto;

	if (znalezioneZloto >= 10)
	{
		liczbaUdanychDni++;
	}
}

Console.WriteLine($"\nŁącznie znaleziono {sumaZlota} sztuk złota.");
Console.WriteLine($"Liczba udanych dni (więcej niż 10 sztuk złota): {liczbaUdanychDni}.");
