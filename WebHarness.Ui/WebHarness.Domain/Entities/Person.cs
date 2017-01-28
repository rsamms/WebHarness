using System;

namespace WebHarness.Domain.Entities
{
    public abstract class Person : EntityBase
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}