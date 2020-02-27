using BlazorAppTutorial.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorAppTutorial.DAL
{
    public class BlazorAppTutorialContext : DbContext
    {
        public BlazorAppTutorialContext(DbContextOptions<BlazorAppTutorialContext> options) : base(options)
        {

        }
        public DbSet<Snowboard> Snowboards { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
