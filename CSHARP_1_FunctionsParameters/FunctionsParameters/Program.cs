// See https://aka.ms/new-console-template for more information
Console.Title = "Parameters";


double weight;
string num;


// Don't need to use out value --> in general it is better to use return but here we have multiple values ... don't yet know how to return multiple values!
static string getWeight ( out double theWeight)
{
    theWeight = 10;
    return "Ten";
}

static double lbToKg(double pounds = 5)
{
    return (pounds * 0.45359237);
 
}

// When passing by ref; parameter cannot have a default value
// This explicitly returns weight 
// You could declare a void here but then couldn't return the value; it would be an output - See bottom for alternative
static double kgToLb (ref double weight)
{
   return weight = (weight / 0.45359237);
}

num = getWeight(out weight);
Console.WriteLine($"{num} lb = {lbToKg(weight)} kg");


// If didn't use return statement in function then need 2 lines - one to get output and then second to use output
// kgToLb(ref weight); 
// Console.WriteLine($"{num} kg = {weight} kg");

Console.WriteLine($"{num} kg = {kgToLb(ref weight)} kg");



