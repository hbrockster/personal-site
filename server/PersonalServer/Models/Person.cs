using System;

namespace PersonalServer.Models
{
    public class Person
    {
        public Name Name { get; set; }
        public string CellPhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public Guid Id { get; set; }
    }
}
