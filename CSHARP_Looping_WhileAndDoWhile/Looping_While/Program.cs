// See https://aka.ms/new-console-template for more information
Console.Title = "Looping .. while ";

int[] nums = new int[10];
int i = 0;

while (i < nums.Length)
{
    //  nums[i] = i;
    //  Console.Write(" | " + nums[i]);
    Console.Write(" | " + i);
    i++;
}

Console.WriteLine("\n\n");


do
{
    i--;
    Console.Write(" | " + i);
}
while (i > 0);

Console.ReadKey();  