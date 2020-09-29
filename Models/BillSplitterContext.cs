using Microsoft.EntityFrameworkCore;

namespace BillSplitterApi.Models
{
    public class BillSplitterContext : DbContext
    {
        public BillSplitterContext(DbContextOptions<BillSplitterContext> options) : base(options) { }

        public DbSet<Event> Event { get; set; }
        public DbSet<Payment> Payment { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<TotalPayment> TotalPayment { get; set; }
    }
}
