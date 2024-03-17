using blazor.famely.calendar.Data.CalendarData;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL.Infrastructure.Internal;

namespace blazor.famely.calendar.Data
{
    public class CalendarDatabaseContext(DbContextOptions<CalendarDatabaseContext> options) : DbContext(options)
    {
        public DbSet<Event> Events { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasKey(e => e.IdKey);
        }
    }
}