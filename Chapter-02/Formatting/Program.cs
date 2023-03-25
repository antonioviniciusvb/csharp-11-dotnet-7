int numberOfApples = 12;
decimal pricePerApple = 0.35M;

Console.WriteLine(
format: "{0} apples cost {1:C}",
arg0: numberOfApples,
arg1: pricePerApple * numberOfApples);

string formatted = string.Format(
format: "{0} apples cost {1:C}",
arg0: numberOfApples,
arg1: pricePerApple * numberOfApples);
//WriteToFile(formatted); // writes the string into a file

//Interpolated strings -- Recommended
Console.WriteLine($"{numberOfApples} apples cost {pricePerApple *
numberOfApples:C}");


//Formatings
string applesText = "Apples";
int applesCount = 1234;

string bananasText = "Bananas";
int bananasCount = 56789;

Console.WriteLine($"{"Name",-10} {"Count",6}");
Console.WriteLine($"{applesText, -10} {applesCount,6:N0}");
Console.WriteLine($"{bananasText,-10} {bananasCount,6:N0}");
