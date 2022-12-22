// See https://aka.ms/new-console-template for more information
Console.Title = "Variables";

char letter; letter = 'A';  // Declared and then initialised
int number; number = 100;   // Declared and then initialised
float body = 98.36F;        // Declared and initialised -needs F suffix to be floating point otherwise will fail to compile
double pi = 3.14159;        // Declared and initialised
decimal sum = 100000m;      // Declared and initialised
bool flag = false;          // Declared and initialised1
string test = "C# is fun";  // Declared and initialised

Console.WriteLine("char letter \t " + letter ) ;
Console.WriteLine("int number \t " + number) ;
Console.WriteLine("float body \t" + body) ;
Console.WriteLine("double pi \t" + pi);
Console.WriteLine("decimal sum \t " + sum);
Console.WriteLine("boolean flag \t " + flag) ;
Console.WriteLine("string test \t " + test) ;


// String Interpolation - much less memory intensive

Console.WriteLine($"char letter \t {letter}");
Console.WriteLine($"int number \t  {number}");
Console.WriteLine($"float body \t {body}");
Console.WriteLine($"double pi \t {pi}");
Console.WriteLine($"decimal sum \t {sum}");
Console.WriteLine($"boolean flag \t {flag}");
Console.WriteLine($"string test \t {test}");


Console.ReadKey();

