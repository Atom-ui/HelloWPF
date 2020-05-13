using System;

namespace HelloWPF
{
    public class Gebruiker
    {
        public Gebruiker(int id, string naam, DateTime birthday)
        {
            Id = id;
            Name = naam;
            Birthday = birthday;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
    }
}
