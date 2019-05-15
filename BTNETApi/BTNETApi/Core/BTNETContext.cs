using BTNETApi.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BTNETApi.Core
{
    public class BTNETContext : DbContext
    {
        public BTNETContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
