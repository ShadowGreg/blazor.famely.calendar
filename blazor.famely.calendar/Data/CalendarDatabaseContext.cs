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
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite( "Server=192.168.50.202;Port=5432;Database=calendar;User Id=postgres;Password=example;" );
            }
        }
        
        public DbSet<Event> Events { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().HasKey(e => e.IdKey);
        }
    }
}