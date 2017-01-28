using System.Collections.Generic;

namespace WebHarness.Domain.Entities
{
    public class Teacher : Person
    {
        public List<Student> Students { get; set; }
    }
}