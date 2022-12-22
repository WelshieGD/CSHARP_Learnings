// See https://aka.ms/new-console-template for more information
Console.Title = "Basic Functions";

// Function that will output 2 text strings to the console but return nothing to the caller
static void bodyTempC()
{
    Console.WriteLine("Body Temperature ...");
    Console.WriteLine("Centigrade: \t 37 degrees C");
}

// Function that will output nothing to the console but reutrn a floating point value to the caller

static double bodyTempF()
{
    double temperature = 98.6;
    return temperature;
}

// Function that will output nothing to the console but reutrn an integer value to the caller

static int bodyTempK()
{
    int temperature = 310;
    return temperature;
}

bodyTempC();
Console.WriteLine ($"Fahrenheit: \t {bodyTempF()} degrees Fahrenheit");
Console.WriteLine ($"Kelvin: \t {bodyTempK()} degrees Kelvin");
Console.ReadKey();  
