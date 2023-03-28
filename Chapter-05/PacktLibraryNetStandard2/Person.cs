using Pack.Shared;

namespace Packt.Shared;

public partial class Person : Object
{
    public const string Species = "Homo Sapiens";

    // read-only fields
    public readonly string HomePlanet = "Earth";

    public readonly DateTime Instantiated;

    public string? Name { get; set; }

    // constants
    public DateTime DateOfBirth { get; set; }

    private WondersOfTheAncientWorld _bucketList;
    public WondersOfTheAncientWorld BucketList
    {
        get { return _bucketList; }
        set
        {
            if (((int)value >> 7) != 0)
            {
                throw new ArgumentOutOfRangeException(nameof(value));
            }

            _bucketList = value;
        }
    }

    public List<Person> Children { get; set; }

    public Person()
    {

        Children = new List<Person>();
        this.Instantiated = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {

        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }

    // deconstructors
    public void Deconstruct(out string? name, out DateTime dob)
    {
        name = Name;
        dob = DateOfBirth;
    }

    public void Deconstruct(out string? name, out DateTime dob, out WondersOfTheAncientWorld fav)
    {
        name = Name;
        dob = DateOfBirth;
        fav = BucketList;
    }
}