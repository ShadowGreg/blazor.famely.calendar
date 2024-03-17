using blazor.famely.calendar.Data.CalendarData;
using blazor.famely.calendar.Data.Domain;

namespace blazor.famely.calendar.Data.Repositories
{
    public class EfRepository(CalendarDatabaseContext databaseContext) : IRepository
    {
        public Task<IEnumerable<Event>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<Event>>(databaseContext.Events.ToList());
        }
        
        public Task<string> AddAsync(Event newEvent)
        {
            if (newEvent == null)
            {
                throw new ArgumentNullException(nameof(newEvent), "Event cannot be null");
            }
            var eventReady = databaseContext.Events.AddAsync(newEvent).Result.Entity;
            databaseContext.SaveChanges();
            return Task.FromResult(eventReady.IdKey);
        }

    }
}