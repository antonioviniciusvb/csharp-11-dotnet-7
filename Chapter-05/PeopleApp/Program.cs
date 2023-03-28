using Packt.Shared;
using PacktLibraryModern;
using System.Threading;
using static Pack.Shared.WondersOfTheAncientWorld;

#region Culture
Thread.CurrentThread.CurrentCulture =
System.Globalization.CultureInfo.GetCultureInfo("pt-BR");

#endregion

#region Sample Class, Enum, Deconstructing

Person bob = new();

bob.Name = "Bob Smith";
bob.BucketList = GreatPyramidOfGiza | ColossusOfRhodes;
bob.DateOfBirth = new DateTime(1965, 12, 22); // C# 1.0 or later

bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new Person { Name = "Zoe" });


//Person leona = new();

//leona.Name = "Leona";
//leona.BucketList = GreatPyramidOfGiza | ColossusOfRhodes;
//leona.DateOfBirth = new DateTime(1969, 1, 05); // C# 1.0 or later

//leona.Children.Add(new Person { Name = "Alfred" });
//leona.Children.Add(new Person { Name = "Zoe" });
//Person.Marry(leona, bob);
//leona.Marry(bob);

Person lamech = new() { Name = "Lamech" };
Person adah = new() { Name = "Adah" };
Person zillah = new() { Name = "Zillah" };
lamech.Marry(adah);
//Person.Marry(zillah, lamech);

if (zillah + lamech)
{
    WriteLine($"{zillah.Name} and {lamech.Name} successfully got married.");
}

WriteLine($"{lamech.Name} is married to {lamech.Spouse?.Name ??
"nobody"}");
WriteLine($"{adah.Name} is married to {adah.Spouse?.Name ?? "nobody"}");
WriteLine($"{zillah.Name} is married to {zillah.Spouse?.Name ??
"nobody"}");

// call instance method
Person baby1 = lamech.ProcreateWith(adah);

// use operator to "multiply"
Person baby3 = lamech * adah;
baby3.Name = "Jubal";
Person baby4 = zillah * lamech;
baby4.Name = "Naamah";

baby1.Name = "Jabal";
WriteLine($"{baby1.Name} was born on {baby1.DateOfBirth}");
// call static method
Person baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tubalcain";
WriteLine($"{lamech.Name} has {lamech.Children.Count} children.");
WriteLine($"{adah.Name} has {adah.Children.Count} children.");
WriteLine($"{zillah.Name} has {zillah.Children.Count} children.");
for (int i = 0; i < lamech.Children.Count; i++)
{
    WriteLine(format: "{0}'s child #{1} is named \"{2}\".",
    arg0: lamech.Name, arg1: i, arg2: lamech[i].Name);
}


// Deconstructing a Person
//var (nameBob, dobBob) = bob; // implicitly calls the Deconstruct method
//WriteLine($"Deconstructed: {nameBob}, {dobBob}");
//var (name2, dob2, fav2) = bob;
//WriteLine($"Deconstructed: {name2}, {dob2}, {fav2}");

//WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}, Favorite: {2}",
//arg0: bob.Name,
//arg1: bob.DateOfBirth,
//arg2: bob.BucketList);

//WriteLine($"{bob.Name} has {bob.Children.Count} children:");

//foreach (Person person in bob.Children)
//{
//    WriteLine($"{person.Name}");
//}


//WriteLine($"Bob is a {Person.Species}");

//WriteLine($"Bob was born on  {bob.HomePlanet}");

//Person gunny = new(initialName: "Gunny", homePlanet: "Mars");
//WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
//arg0: gunny.Name, arg1: gunny.HomePlanet, arg2: gunny.Instantiated);


#endregion

#region Sample Static Members

//BankAccount.InterestRate = 0.012M; //store a shared value

//BankAccount jonesAccount = new()
//{
//    AccountName = "Mrs. Jones",
//    Balance = 2400
//};

//WriteLine($"{jonesAccount.AccountName} earned " +
//        $"{jonesAccount.Balance * BankAccount.InterestRate:C}");

//BankAccount gerrierAccount = new()
//{
//    AccountName = "Mrs. Gerrier",
//    Balance = 98
//};

//WriteLine($"{gerrierAccount.AccountName} earned " +
//        $"{gerrierAccount.Balance * BankAccount.InterestRate:C}");

#endregion

#region Tuples

//LifeTheUniverseAndEverything lifeTheUniverseAndEverything = new LifeTheUniverseAndEverything();
//var textAndnumber = lifeTheUniverseAndEverything.GetTheData();

//WriteLine($"{textAndnumber.Text} - {textAndnumber.Number}");


//var tuples = lifeTheUniverseAndEverything.GetTuple();

//WriteLine($"{tuples.Text} - {tuples.Number}");

//(string name, int number)  = lifeTheUniverseAndEverything.GetTuple();

//WriteLine($"{name} - {number}");

#endregion

#region Properties
//Person sam = new()
//{
//    Name = "Mrs Sam",
//    BucketList = WondersOfTheAncientWorld.GreatPyramidOfGiza | WondersOfTheAncientWorld.ColossusOfRhodes,
//    DateOfBirth = new DateTime(1994, 07, 23)
//};

//WriteLine(sam.Origin);
//WriteLine(sam.Greeting);
//WriteLine(sam.Age);

//sam.FavoriteIceCream = "Chocolate Fudge";
//WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}.");
//string color = "Red";
//try
//{
//    sam.FavoritePrimaryColor = color;
//    WriteLine($"Sam's favorite primary color is {sam.
//    FavoritePrimaryColor}.");
//}
//catch (Exception ex)
//{
//    WriteLine("Tried to set {0} to '{1}': {2}",
//    nameof(sam.FavoritePrimaryColor), color, ex.Message);
//}


#endregion


//Book book = new()
//{
//    Isbn = "978-1803237899",
//    Title = "C# 11 and .NET 7 - Modern Cross-Plataform Development"
//};

Book book = new(isbn: "978-1803237800", 
    title: "C# 11 and .NET 7 - Modern Cross-Platform Development Fundamentals")
{
Author = "Mark J. Price",
PageCount = 821
};

WriteLine("{0}: {1} written by {2} has {3:N0} pages.",
book.Isbn, book.Title, book.Author, book.PageCount);

ReadKey();


