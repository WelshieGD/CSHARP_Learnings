// See https://aka.ms/new-console-template for more information
Console.Title = ("Casting");

double num = 10.5;
int integer1 = 7;
int integer2= 2;

/*
This would generate an error:

int sum = num + integer;

Cannot implicitly convert type 'double' to 'int'. An explicit conversion exists (are you missing a cast?)
*/

// Implicit Casting - C# will cast automatically e.g. smaller numbers to bigger ones
num = num + integer1;
Console.WriteLine("Implicit Cast : " + num);
Console.WriteLine("This is data type " + num.GetType());
Console.WriteLine("This is data type " + integer1.GetType());

// Implicit Casting Can cause data loss \ pollution - 7/2 = 3 if implicit casting used
num = integer1 / integer2;
Console.WriteLine("Implicit Cast gives the wrong answer = 7/2 = " + num);

// Need to explicitly cast to prevent rounding errors
num = (double)integer1 / integer2;
Console.WriteLine("Explicit Cast gives the correct answer = 7/2 = " + num);

// Cast an integer value into a char data type to display Unicode equivalent
char letter  = (char) 65;
Console.WriteLine("Cast Integer: " + letter);

// Cast a character as an int data type to display Unicode code number
int unicode = (int)'A';
Console.WriteLine("Cast letter: " + unicode);

