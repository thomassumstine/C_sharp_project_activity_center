using Microsoft.EntityFrameworkCore;

namespace DojoActivityCenter.Models
{
    public class DojoActivityCenterContext : DbContext
    {
        public DojoActivityCenterContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<ActivityEvent> ActivityEvent {get;set;}

        public DbSet<Join> Join {get;set;}
    }
}