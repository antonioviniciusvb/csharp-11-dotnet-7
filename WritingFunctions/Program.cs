TimesTable(7);

try
{
    int factorial = Factorial(13);
    WriteLine($"10! = {factorial:N0}");
}
catch (OverflowException overFlowException)
{
    WriteLine(overFlowException.Message);
}

ReadKey();