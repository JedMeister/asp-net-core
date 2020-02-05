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
                new ExampleThing{Title="First item", Data="Bunch of random data"},
                new ExampleThing{Title="Second item", Data="Even more random data"},
                new ExampleThing{Title="Last item", Data="A substantially larger amount of random data purely for the purpose of an example" },
            };

            foreach (ExampleThing t in things)
            {
                context.ExampleThings.Add(t);
            }
            context.SaveChanges();
        }
    }
}

