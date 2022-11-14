using Doorways;
using Doorways.Entities;
using SecretHistories.Entities;
using SecretHistories.Fucine.DataImport;
using SecretHistories.Fucine;
using System;
using System.Collections.Generic;
using SecretHistories.Core;

namespace DoorwaysSampleMod
{
    [DoorwaysObject]
    public class ExampleCard : Card
    {
        public override string Label { get; set; } = "A Sharp Sea";
        public override string Description { get; set; } = "This card was made using Doorways and C#";
        public new AspectsDictionary Aspects { get; set; } = new AspectsDictionary(new Dictionary<string, int>
        {
            { "ingredient", 1 },
            { "funds", 24 }
        });
    }
}
