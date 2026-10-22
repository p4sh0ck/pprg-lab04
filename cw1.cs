int lRosnie = 1;
Console.Write("Rosnąco z while: ");
while (lRosnie > 0 && lRosnie <= 10){
    Console.Write($"{lRosnie} ");
    lRosnie++;
}

int lRosnie2 = 1;
Console.Write("\nRosnąco z do-while: ");
do
{
    Console.Write($"{lRosnie2} ");
    lRosnie2++;
}
while (lRosnie2 > 0 && lRosnie2 <= 10);

Console.Write("\nRosnąco z for: ");
for(int lRosnie3 = 1; lRosnie3 <=10 ; lRosnie3++)
{
    Console.Write($"{lRosnie3} ");
}

Console.Write("\nMalejąco z for: ");
for(int lMaleje = 10; lMaleje >= 1; lMaleje--)
{
    Console.Write($"{lMaleje} ");
}

Console.Write("\nParzyste z for: ");
for(int parzysta = 0; parzysta <=20; parzysta += 2)
{
    Console.Write($"{parzysta} ");
}

Console.WriteLine("\nStart!");