//Display bytes in memory and min and max values ​​of types:
//sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.

var separator = new string('-', 74);

var header = $"{"Type",-10}{"Byte (s) of Memory"}{"Min",16}{"Max",30}";

Console.WriteLine(separator);
Console.WriteLine(header);

var body = $"""
{"sbyte", -10}{Marshal.SizeOf(typeof(sbyte)),-4}{sbyte.MinValue, 30}{sbyte.MaxValue,30}
{"byte",-10}{Marshal.SizeOf(typeof(byte)),-4}{byte.MinValue,30}{byte.MaxValue,30}
{"short",-10}{Marshal.SizeOf(typeof(short)),-4}{short.MinValue,30}{short.MaxValue,30}
{"ushort",-10}{Marshal.SizeOf(typeof(ushort)),-4}{ushort.MinValue,30}{ushort.MaxValue,30}
{"int",-10}{Marshal.SizeOf(typeof(int)),-4}{int.MinValue,30}{int.MaxValue,30}
{"uint",-10}{Marshal.SizeOf(typeof(uint)),-4}{uint.MinValue,30}{uint.MaxValue,30}
{"long",-10}{Marshal.SizeOf(typeof(long)),-4}{long.MinValue,30}{long.MaxValue,30}
{"ulong",-10}{Marshal.SizeOf(typeof(ulong)),-4}{ulong.MinValue,30}{ulong.MaxValue,30}
{"float",-10}{Marshal.SizeOf(typeof(float)),-4}{float.MinValue,30}{float.MaxValue,30}
{"double",-10}{Marshal.SizeOf(typeof(double)),-4}{double.MinValue,30}{double.MaxValue,30}
{"decimal",-10}{Marshal.SizeOf(typeof(decimal)),-4}{decimal.MinValue,30}{decimal.MaxValue,30}
""";

Console.WriteLine(body);