using Packt.Shared;
using PacktShare;
using static Pack.Shared.WondersOfTheAncientWorld;

Thread.CurrentThread.CurrentCulture =
System.Globalization.CultureInfo.GetCultureInfo("en-GB");

#region Sample Class, Enum
//Person bob = new();
//WriteLine(bob.ToString());

//bob.Name = "Bob Smith";
//bob.BucketList = GreatPyramidOfGiza|ColossusOfRhodes;
//bob.DateOfBirth = new DateTime(1965, 12, 22); // C# 1.0 or later

//bob.Children.Add(new Person { Name = "Alfred" });
//bob.Children.Add(new Person { Name = "Zoe" });

//WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}, Favorite: {2}",
//arg0: bob.Name,
//arg1: bob.DateOfBirth,
//arg2: bob.BucketList);

//WriteLine($"{bob.Name} has {bob.Children.Count} children:");

//foreach (Person person in bob.Children)
//{
//    WriteLine($"{person.Name}");
//}

#endregion

#region Sample Static Members

BankAccount.InterestRate = 0.012M; //store a shared value

BankAccount jonesAccount = new()
{
    AccountName = "Mrs. Jones",
    Balance = 2400
};

WriteLine($"{jonesAccount.AccountName} earned " +
        $"{jonesAccount.Balance * BankAccount.InterestRate:C}");

BankAccount gerrierAccount = new()
{
    AccountName = "Mrs. Gerrier",
    Balance = 98
};

WriteLine($"{gerrierAccount.AccountName} earned " +
        $"{gerrierAccount.Balance * BankAccount.InterestRate:C}");

#endregion

ReadKey();