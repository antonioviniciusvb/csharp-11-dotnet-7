public partial class Program
{

    static void TimesTable(int number)
    {
        WriteLine($"TimesTable: {number}");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number,-2} X {i,2} ={number * i,3}");
        }
    }

    static int Factorial(int number)
    {

        if (number < 0)
        {
            throw new ArgumentException(message: "The factorial function is defined for non-negative" +
                $"integers only. Input {number}", paramName: nameof(number));
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            return number * Factorial(number - 1);
        }
    }
}
