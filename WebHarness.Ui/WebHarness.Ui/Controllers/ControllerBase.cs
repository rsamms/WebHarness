using System.Web.Mvc;
using WebHarness.Domain.Data;

namespace WebHarness.Ui.Controllers
{
    public abstract class ControllerBase: Controller
    {
        protected ControllerBase(DataContext dataContext)
        {
            Database = dataContext;
        }

        protected DataContext Database { get; private set; }
    }
}