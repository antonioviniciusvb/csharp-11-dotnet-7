namespace Packt.Shared;

public partial class Person
{
    //a readonly property defined using c# 1 - 5 syntax
    public string Origin
    {
        get { return string.Format("{0} eas born on {1}", Name, HomePlanet); }
    }

    //two readonly properties defined using c# 6+ Lambada expression body
    public string Greeting => $"{Name} says Hello!";
    public int Age => DateTime.Today.Year - DateOfBirth.Year;

    // a read-write property defined using C# 3.0 syntax
    public string? FavoriteIceCream { get; set; } // auto-syntax

    // a private field to store the property value
    private string? favoritePrimaryColor;
    // a public property to read and write to the field
    public string? FavoritePrimaryColor
    {
        get
        {
            return favoritePrimaryColor;
        }
        set
        {
            switch (value?.ToLower())
            {
                case "red":
                case "green":
                case "blue":
                    favoritePrimaryColor = value;
                    break;
                default:
                    throw new ArgumentException(
                    $"{value} is not a primary color. " +
                    "Choose from: red, green, blue.");
            }
        }
    }

    private bool married = false;
    public bool Married => married;
    private Person? spouse = null;
    public Person? Spouse => spouse;

    // static method to marry
    public static void Marry(Person p1, Person p2)
    {
        p1.Marry(p2);
    }

    // instance method to marry
    public void Marry(Person partner)
    {
        if (married) return;
        spouse = partner;
        married = true;
        partner.Marry(this); // this is the current object
    }

    // static method to "multiply"
    public static Person Procreate(Person p1, Person p2)
    {
        if (p1.Spouse != p2)
        {
            throw new ArgumentException("You must be married to procreate.");
        }
        Person baby = new()
        {
            Name = $"Baby of {p1.Name} and {p2.Name}",
            DateOfBirth = DateTime.Now
        };
        p1.Children.Add(baby);
        p2.Children.Add(baby);
        return baby;
    }
    // instance method to "multiply"
    public Person ProcreateWith(Person partner)
    {
        return Procreate(this, partner);
    }

    public static bool operator +(Person p1, Person p2)
    {
        Marry(p1, p2);
        return p1.Married && p2.Married;
    }

    public static Person operator *(Person p1, Person p2)
    {
        return Procreate(p1,p2);
    }
}
