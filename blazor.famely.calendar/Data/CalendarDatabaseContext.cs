using blazor.famely.calendar.Data.CalendarData;
using Microsoft.EntityFrameworkCore;

namespace blazor.famely.calendar.Data
{
    public class CalendarDatabaseContext : DbContext
    {
        public CalendarDatabaseContext(DbContextOptions<CalendarDatabaseContext> options) : base(options)
        {
        }

        public CalendarDatabaseContext()
        {
        }
        
        public DbSet<Event> Events { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasKey(e => e.IdKey);
        }
    }
}