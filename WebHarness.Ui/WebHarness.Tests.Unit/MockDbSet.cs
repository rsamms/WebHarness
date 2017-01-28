using System.Data.Entity;
using WebHarness.Domain.Entities;

namespace WebHarness.Tests.Unit
{
    public class MockDbSet<T>: DbSet<T> where T: EntityBase
    {
    }
}
