using blazor.famely.calendar.Data.CalendarData;
using Microsoft.EntityFrameworkCore;

namespace blazor.famely.calendar.Data.Repositories
{
    public class EfRepository
    {
        private readonly CalendarDatabaseContext _databaseContext = new CalendarDatabaseContext();
        
        public Task<IEnumerable<Event>> GetAllAsync()
        {
            return Task.FromResult<IEnumerable<Event>>(_databaseContext.Events.ToList());
        }
        
        public Task<string> AddAsync(Event newEvent)
        {
            if (newEvent == null)
            {
                throw new ArgumentNullException(nameof(newEvent), "Event cannot be null");
            }
            var eventReady = _databaseContext.Events.AddAsync(newEvent).Result.Entity;
            return Task.FromResult(eventReady.IdKey);
        }

    }
}