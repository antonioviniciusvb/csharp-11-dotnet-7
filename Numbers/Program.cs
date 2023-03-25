//unsigned integer means positive whole number or 0
using System;

uint naturalNumber = 23;

//integer means negative or positive whole number or 0
int integerNumber = -23;

//float means single-precision floating point
//F sufflix make it a float literal
float realNumber = 2.3F;

//double means double-precision floating point
//double is the default type for a number value with a decimal point 
double anotherRealNumber = 2.3;

//Improve C# 7.0 - Digit separators
double numberWithSeparatorDigits = 1_000_000_000.50;

//Three variables that store the number 2 million
int decimalNotation = 2_000_000;

//0b_...
int binaryNotation = 0b_001_1110_1000_0100_1000_0000;

//0x_...
int hexadecimalNotation = 0x_001E_8480;

//Check the three variables have the same value
//both statements output true
Console.WriteLine($"{decimalNotation == binaryNotation && decimalNotation == hexadecimalNotation}");

//Number Sizes
Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers " +
    $" in the range { int.MinValue:N0} to {int.MaxValue:N0}.");

Console.WriteLine($"double uses {sizeof(double)} bytes and can store" +
    $"numbers in the range { double.MinValue:N0} to {double.MaxValue:N0}.");

Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store" +
    $"numbers in the range { decimal.MinValue:N0} to {decimal.MaxValue:N0}.");


Console.WriteLine("Wrong Way - Using doubles:");
double a = 0.1;
double b = 0.2;
if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
}


Console.WriteLine("Wrong Way - Using doubles:");
decimal c = 0.1m;
decimal d = 0.2m;
if (c + d == 0.3m)
{
    Console.WriteLine($"{c} + {d} equals {0.3}");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal {0.3}");
}
Console.ReadKey();