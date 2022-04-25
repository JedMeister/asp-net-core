using System;
using System.Collections.Generic;

namespace TurnkeyExampleApp.Models
{
    public class ExampleThing
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Data { get; set; }

        public ExampleThing(string title, string data) {
            Title = title;
            Data = data;
        }
    }
}
