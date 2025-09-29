using Microsoft.VisualBasic;

string input = Console.ReadLine();
int year = int.Parse(input);

if (((year % 4) == 0) && ((year % 100) != 0))
    Console.WriteLine("leap year");

if (year % 400 == 0)
    Console.WriteLine("leap year");