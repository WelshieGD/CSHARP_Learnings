// See https://aka.ms/new-console-template for more information
// arrays are zero based

// Single dimensional array examples
Console.Title = "Arrays";

// Declare an array - this does not initialise the array in memory
string[] cars; 

// Initialise array
cars = new string[]  { "Ford", "BMW", "VW" };

// Declare and initialise an array in one statement

string[] bassguitars = { "Fender", "Yamaha", "Ibanez", "Cort" };

Console.WriteLine("The second car in the list is " + cars[1]);
Console.WriteLine("The third bass in the list is " + bassguitars[2]);

Console.ReadKey();


//multi-dimensional array examples
int[,] coordinates = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

// First dimension - 1st item

Console.WriteLine("X1,Y1: " + coordinates[0, 0]);

// Second dimension - 3rd item
Console.WriteLine("X2,Y3: " + coordinates[1, 2]);
