// See https://aka.ms/new-console-template for more information
Console.Title = "IFElse Statements";

// There is no error checking here to ensure that only a number or a single character was entered

Console.Write("Please enter a number: ");
double num = Convert.ToDouble(Console.ReadLine());

Console.Write("Thanks; now please enter a letter: ");
char letter = Convert.ToChar(Console.ReadLine());

if (num > 6)
{
    Console.WriteLine("You entered the number " + num + "; which is greater than 6");
}

else
{
    Console.WriteLine("You entered the number " + num + "; which is equal to or less than 6");
}
Console.ReadKey();

// Check if letter is a vowel
bool isVowel = "aeiouAEIOU".IndexOf(letter) >= 0;

if (isVowel == true)
{
    Console.WriteLine("You entered the letter " + letter + "; which is a vowel");
}

else
{
    Console.WriteLine("You entered the letter " + letter + "; which is a consonant");
}

