// See https://aka.ms/new-console-template for more information

Console.Title = "Overloading Methods";

/*
You could create 3 classes - one to computr area of a circle, one to compute area of a sqaure and one to compute area of a triangle
This shows the area of a circle ... but a neater way is to overlad the method
One class - 3 methods with the same name - the "right" one will be run dependant on the number of variables passed to it. 

// Declare 2 floating point variables and an instance of a class named Compute
double num;
double area;
Compute size = new();

// Initialise first variable from console input
Console.Write("Please enter the dimension: ");
num = Convert.ToDouble(Console.ReadLine());

// Initialise first variable from console input
area = size.Zone(num);
Console.WriteLine($"\nCircle: \tArea = {area} sq meters");

// Class 
class Compute
{
    public double Zone(double width)
    {
        double radius = width / 2;
        return ((radius * radius) * 3.141593);
    }
}


*/

// Declare 2 floating point variables and an instance of a class named Compute
double num;
double area;
Compute size = new();

// Initialise first variable from console input
Console.Write("Please enter the dimension: ");
num = Convert.ToDouble(Console.ReadLine());

// Initialise first variable from console input
area = size.Zone(num);
Console.WriteLine($"\nCircle: \tArea = {area} sq meters");

// Initialise first variable from console input
area = size.Zone(num, num);
Console.WriteLine($"\nSquare: \tArea = {area} sq meters");


// Initialise first variable from console input - T is just used as a flag that is is for the triangle method 
area = size.Zone(num, num, 'T');
Console.WriteLine($"\nTriangle: \tArea = {area} sq meters");

// Class 
class Compute
{
    public double Zone(double width)
    {
        double radius = width / 2;
        return ((radius * radius) * 3.141593);
    }

    public double Zone(double width, double height)
    {
            return (width * height);
    }

    public double Zone(double width, double height, char c)
    {
        return ((width / 2) * height);
    }
}