Console.Title = "Looping - For Each Loop";

string[] websites = new string[5] { "Google", "YouTube", "Facebook", "Baidu", "Yahoo" };

Console.WriteLine("Popular websites .... ");
int num = 1;

foreach (string site in websites)
{
    Console.WriteLine("Position " + num + "\t " + site);
    num ++;
    // can use a break; to exit a foreach loop early 
}




