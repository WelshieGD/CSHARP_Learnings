// See https://aka.ms/new-console-template for more information
Console.Title = "Logic";

bool yes = true;
bool no = false;

Console.WriteLine("AND Logic:");
Console.WriteLine("\n\t (yes && yes) \t: " + (yes && yes));
Console.WriteLine("\n\t (yes && no) \t: " + (yes && no));
Console.WriteLine("\n\t (no && yes) \t: " + (no && yes));
Console.WriteLine("\n\t (no && no) \t: " + (no && no));

Console.WriteLine("OR Logic:");
Console.WriteLine("\n\t (yes || yes) \t: " + (yes || yes));
Console.WriteLine("\n\t (yes || no) \t: " + (yes || no));
Console.WriteLine("\n\t (no || yes) \t: " + (no || yes));
Console.WriteLine("\n\t (no || no) \t: " + (no || no));

