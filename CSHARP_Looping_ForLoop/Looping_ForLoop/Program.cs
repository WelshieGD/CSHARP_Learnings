// See https://aka.ms/new-console-template for more information
Console.Title = "Looping - For Loop";

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Outer Loop ... " + i);

    for (int j = 0; j < 4; j++)
    {
        Console.WriteLine("\t Inner Loop ... " + j);
    }
}
