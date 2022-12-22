// See https://aka.ms/new-console-template for more information
Console.Title="Conditional Logic";

// Declare and intialise in one statement
// Could also have done seperate declare and initialise
// int [] numbers;
// numbers = new int [] { 1, 4, 7};

int[] numbers = { 1, 4, 12 };

foreach (int i in numbers)
{
    string verb = (i != 1) ? "are" : "is";
    Console.WriteLine("There " + verb + i + " aircraft");
}

string parity;

parity = ((numbers[2] / numbers[0])%2 !=0 ) ? "Odd": "Even";
Console.WriteLine(numbers[2] + " / " + numbers[0] + " is " + numbers[2] / numbers[0] + " which is " + parity);

parity = ((numbers[2] / numbers[1]) % 2 != 0) ? "Odd" : "Even";
Console.WriteLine(numbers[2] + " / " + numbers[1] + " is " + numbers[2] / numbers[1] + " which is " + parity);
