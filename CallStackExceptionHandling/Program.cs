using CallStackExcepetionHandlingLib;
using System.Diagnostics;

WriteLine("In main");

try
{
    Alpha();

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.InnerException);
}

void Alpha()
{
    WriteLine("In Alpha");
    Beta();
}

void Beta()
{
    WriteLine("In Beta");

    try
    {
        Calculator.Gamma();
    }
    catch (IOException ex)
    {
        LogException(ex);

        // throw the caught exception as if it happened here
        // this will lose the original call stack
        throw ex;
        // rethrow the caught exception and retain its original call stack
        throw;
        // throw a new exception with the caught exception nested within it
        throw new InvalidOperationException(
        message: "Calculation had invalid values. See inner exception for why.",
        innerException: ex);
    }
}

void LogException(IOException ex)
{
    Debug.WriteLine(ex);
}