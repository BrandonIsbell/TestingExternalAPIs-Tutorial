using System;
using System.Collections.Generic;
using System.Text;

namespace CallingExternalAPI.Models
{
    public class Joke
    {
        public string Type { get; set; }
        public JokeContents Value { get; set; }
    }

    public class JokeContents
    {
        public int Id { get; set; }
        public string Joke { get; set; }
    }
}
