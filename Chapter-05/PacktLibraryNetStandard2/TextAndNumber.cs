using System;
using System.Collections.Generic;
using System.Text;

namespace Pack.Shared;

public  class TextAndNumber
{
    public string Text { get; set; }
    public int Number { get; set; }

}

public class LifeTheUniverseAndEverything
{
    public TextAndNumber GetTheData()
    {
        return new TextAndNumber
        {
            Text = "What's the meaning of life?",
            Number = 42
        };
    }

    public (string Text, int Number) GetTuple() => new("What's the meaning of life?", 42);
}
