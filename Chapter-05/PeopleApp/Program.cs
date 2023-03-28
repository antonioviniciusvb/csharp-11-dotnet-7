using Packt.Shared;
using static Pack.Shared.WondersOfTheAncientWorld;

Person bob = new();
WriteLine(bob.ToString());

bob.Name = "Bob Smith";
bob.BucketList = GreatPyramidOfGiza|ColossusOfRhodes;
bob.DateOfBirth = new DateTime(1965, 12, 22); // C# 1.0 or later

bob.Children.Add(new Person { Name = "Alfred" });
bob.Children.Add(new Person { Name = "Zoe" });

WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}, Favorite: {2}",
arg0: bob.Name,
arg1: bob.DateOfBirth,
arg2: bob.BucketList);

WriteLine($"{bob.Name} has {bob.Children.Count} children:");

foreach (Person person in bob.Children)
{
    WriteLine($"{person.Name}");
}

ReadKey();