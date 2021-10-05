using System;

namespace PersonalServer.Models
{
    public class Person
    {
        public Guid Id { get; set; }
        public Name Name { get; set; }
        public string CellPhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public string Bio { get; set; }
    }
}
