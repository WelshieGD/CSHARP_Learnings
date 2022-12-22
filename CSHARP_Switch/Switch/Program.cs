// See https://aka.ms/new-console-template for more information

Console.Title = ("Switching");
Console.Write("Please enter a number from 1 to 7 (including either 1 or 7)");

// You need to initialise day and position for this code to work
int num = Convert.ToInt16(Console.ReadLine());
string day = "No day selected";
string position = "No day selected";

switch(num)
{
   case 1 : day = "Monday"; position = "first"; break;
    case 2: day = "Tuesday"; position = "second";  break;
    case 3: day = "Wednesday"; position = "third"; break;
    case 4: day = "Thursday"; position = "fourth"; break;
    case 5: day = "Friday"; position = "fifth"; break;
    case 6: day = "Saturday"; position = "sixth"; break;
    case 7: day = "Sunday"; position = "seventh"; break;
    default: day = "a number not between 1 and 7"; position = " impossible";break;
}

Console.WriteLine("You chose " + day + " which is the " + position + " day of the week");


// case does not accept ranges but you can include when clause in case statement since c#7 
/*
int age = 12;
switch (age)
{
    case int i when i >= 1 && i <= 8:
        System.Console.WriteLine("You are only " + age + " years old. You must be kidding right. Please fill in your *real* age.");
        break;
    case int i when i >= 9 && i <= 15:
        System.Console.WriteLine("You are only " + age + " years old. That's too young!");
        break;
    case int i when i >= 16 && i <= 100:
        System.Console.WriteLine("You are " + age + " years old. Perfect.");
        break;
    default:
        System.Console.WriteLine("You an old person.");
        break;
}
*/