using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("name:");
        string name = Console.ReadLine();

        Console.WriteLine("age:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("total price:");
        double totalAmount = double.Parse(Console.ReadLine());

        double discount = 0;

        if (totalAmount < 50)
        {
            discount = 0;
        }
        else if (totalAmount >= 50 && totalAmount <= 100)
        {
            discount = 0.05;
        }
        else
        {
            discount = 0.10; 
        }

        if (age < 18)
        {
            discount += 0.02; 
        }

        double discountAmount = totalAmount * discount;
        double finalAmount = totalAmount - discountAmount;

        Console.WriteLine($"{name}");
        Console.WriteLine($"{finalAmount:F2}"); 
    }
}
