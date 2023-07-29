using Authentification_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Authentification_API.Context
{
    public class AuthBdContext: DbContext
    {
        public AuthBdContext(DbContextOptions<AuthBdContext> options) : base(options)
        {
            
        }
        public DbSet<User> users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("users");
        }
    }
}
