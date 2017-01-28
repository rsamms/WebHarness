using System.Collections.Generic;
using System.Web.Mvc;
using WebGrease.Css.Extensions;
using WebHarness.Domain.Data;
using WebHarness.Ui.Models;

namespace WebHarness.Ui.Controllers
{
    public class StudentController : ControllerBase
    {
        // GET: Student
        public StudentController(DataContext dataContext) : base(dataContext)
        {
        }

        public ActionResult Index()
        {


            List < StudentViewModel >studentViewModels = new List<StudentViewModel>();

            Database.Students.ForEach(x =>
            {
                studentViewModels.Add(new StudentViewModel
                {
                    CourseViewModel = new CourseViewModel {Name = x.Course.Name},
                    DateOfBirth = x.DateOfBirth,
                    FirstName = x.FirstName,
                    LastName = x.LastName
                });
            });

            return View(studentViewModels);
        }
    }
}