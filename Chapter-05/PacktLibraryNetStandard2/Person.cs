﻿using Pack.Shared;

namespace Packt.Shared;

public class Person : Object
{
    public string? Name { get; set; }
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