//Display bytes in memory and min and max values ​​of types:
//sbyte, byte, short, ushort, int, uint, long, ulong, float, double, and decimal.

var separator = new string('-', 74);

var header = $"{"Type",-10}{"Byte (s) of Memory"}{"Min",16}{"Max",30}";

WriteLine(separator);
WriteLine(header);

var body = $"""
{"sbyte", -10}{sizeof(sbyte),-4}{sbyte.MinValue, 30}{sbyte.MaxValue,30}
{"byte",-10}{sizeof(byte),-4}{byte.MinValue,30}{byte.MaxValue,30}
{"short",-10}{sizeof(short),-4}{short.MinValue,30}{short.MaxValue,30}
{"ushort",-10}{sizeof(ushort),-4}{ushort.MinValue,30}{ushort.MaxValue,30}
{"int",-10}{sizeof(int),-4}{int.MinValue,30}{int.MaxValue,30}
{"uint",-10}{sizeof(uint),-4}{uint.MinValue,30}{uint.MaxValue,30}
{"long",-10}{sizeof(long),-4}{long.MinValue,30}{long.MaxValue,30}
{"ulong",-10}{sizeof(ulong),-4}{ulong.MinValue,30}{ulong.MaxValue,30}
{"float",-10}{sizeof(float),-4}{float.MinValue,30}{float.MaxValue,30}
{"double",-10}{sizeof(double),-4}{double.MinValue,30}{double.MaxValue,30}
{"decimal",-10}{sizeof(decimal),-4}{decimal.MinValue,30}{decimal.MaxValue,30}
""";

WriteLine(body);