// See https://aka.ms/new-console-template for more information
Console.Title = "Enumerations, Constants and vars";

// var - variant - must be assigned a value when declared
// constant - when a stored value is never intended to be changed. Must assign a value when declared
// enum - multiple constants in an enumerator list (zero based)


//var and enum to create an enumerationm and assign it to a variable
var daystype = typeof(BusinessDays);

// Check if enum value exists
//if ( Enum.IsDefined(typeof(BusinessDays), 2))

// Warning CS8600 - Converting null literal or possible null value to non-nullable type
// string mydays = Enum.GetName(daystype, 2);
// Console.WriteLine(mydays);

// Workaround 1 for warning - provide a return vale
// string mydays = Enum.GetName(daystype, 28) ?? "Unknown value";
// Console.WriteLine(mydays);

// Workaround 2 for warning - Add null forgiving operator on right hand side

string mydays = Enum.GetName(daystype, 8)!;
Console.WriteLine(mydays);
