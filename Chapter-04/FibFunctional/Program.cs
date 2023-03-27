WriteLine("Fibonacci Functional");
RunFibFunctional();

static int FibFunctional(int term) =>
    term switch
    {
        1 => 0,
        2 => 1,
        > 2 => FibFunctional(term - 1) + FibFunctional(term - 2),
        _ => 0
    };

static void RunFibFunctional()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine($"term {i, -5:N0} {FibFunctional(i), 10:N0}");
    }
}