using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebHarness.Domain.Entities
{
    public class Course : EntityBase
    {
        public virtual string Name { get; set; }
    }
}
