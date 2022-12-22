// See https://aka.ms/new-console-template for more information
// Dictionary has .Add() and .Remove() methods

Console.Title = "Dictionary";

Dictionary<string, string> Booklist = new Dictionary<string, string>();

Booklist.Add("Dickens", "Oliver Twist");
Booklist.Add("Conrad", "Heart of Darkness");
Booklist.Add("Tolstoy", "Anna Karenina");

Console.WriteLine("Popular Titles ..");

foreach (KeyValuePair<string, string> book in Booklist)
{
    Console.WriteLine("Author:\t" + book.Key + "\tBook:\t" + book.Value);
}

Console.ReadKey();