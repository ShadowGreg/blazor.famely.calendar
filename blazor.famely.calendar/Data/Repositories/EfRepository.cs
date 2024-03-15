using blazor.famely.calendar.Data.CalendarData;
using blazor.famely.calendar.Data.Domain;

namespace blazor.famely.calendar.Data.Repositories
{
    public class EfRepository : IRepository
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
            _databaseContext.SaveChanges();
            return Task.FromResult(eventReady.IdKey);
        }

    }
}