using CP_2TDSPB.Models;
using Microsoft.EntityFrameworkCore;

namespace CP_2TDSPB.Data
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options) : base(options) { }

        public DbSet<user> Users { get; set; }
    }
}
