using Pack.Shared;

namespace Packt.Shared;

public class Person : Object
{
    public const string Species = "Homo Sapiens";

    // read-only fields
    public readonly string HomePlanet = "Earth";

    public string? Name { get; set; }

    // constants
    public DateTime DateOfBirth { get; set; }

    private WondersOfTheAncientWorld _bucketList;
    public WondersOfTheAncientWorld BucketList
    {
        get { return _bucketList; }
        set
        {
            if(((int)value >> 7) != 0)
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
    }


}
