public partial class Program
{

    static void TimesTable(int number)
    {
        WriteLine($"TimesTable: {number}");

        for (int i = 1; i <= 10; i++) 
        {
            Console.WriteLine($"{number, -2} X {i, 2} ={number * i, 3}");
        }
    }
}
