class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        float num = float.Parse(input);
        if (num / 2 == 0)
        {
            Console.WriteLine("Even");
        }
        else
        {
            Console.WriteLine("Odd");
        }
    }
}