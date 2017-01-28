using System;
using System.Collections.Generic;

namespace WebHarness.Ui.Models
{
    public class StudentRosterViewModel
    {
        public List<StudentViewModel> Students { get; set; }
    }
    public class StudentViewModel
    {
        public CourseViewModel CourseViewModel { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
