// See https://aka.ms/new-console-template for more information
Console.Title = "Input And Convert Data types";

Console.Write("Please enter a number: ");
double num = Convert.ToDouble(Console.ReadLine());

Console.Write("Now enter another number: ");
double sum = num + Convert.ToDouble(Console.ReadLine());


//System.Convert class provides a number of methods to convert data types
// Convert.ToInt16
// Convert.ToInt32
// Convert.ToDecimal
// Convert.ToBase64String
// Convert.ToString   
// Convert.ToBoolean
// Convert.ToChar
// Convert.ToDateTime

Console.WriteLine("Total = " + sum);
Console.WriteLine("This is data type " + sum.GetType());


Console.ReadKey();

// C# lilteal numbers with a decimal point are always double and not floating point ... you need to suffix F to make it Floating Point. 


// Casting is different from converting
// A value stored in a variable can be forced into a variable of a
// different data type by casting the value to a different data type
// Implicit - Automatically done by C# in a type-safe manner when casting numbers from smaller to larger data types (int to double)
// Explicit - When in your opinion it is safe to do so using Cast key word

