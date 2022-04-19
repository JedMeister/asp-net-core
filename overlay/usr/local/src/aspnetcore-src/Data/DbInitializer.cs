using TurnkeyExampleApp.Data;
using TurnkeyExampleApp.Models;
using System;
using System.Linq;

namespace TurnkeyExampleApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ExampleContext context)
        {
            context.Database.EnsureCreated();

            if (context.ExampleThings.Any())
            {
                return;
            }

            var things = new ExampleThing[]
            {
                new ExampleThing("First item", "Bunch of random data"),
                new ExampleThing("Second item", "Even more random data"),
                new ExampleThing("Last item", "A substantially larger amount of random data purely for the purpose of an example" ),
            };

            foreach (ExampleThing t in things)
            {
                context.ExampleThings.Add(t);
            }
            context.SaveChanges();
        }
    }
}

