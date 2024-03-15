using blazor.famely.calendar.Data.CalendarData;

namespace blazor.famely.calendar.Data.Domain
{
    public interface IRepository
    {
        Task<IEnumerable<Event>> GetAllAsync();
        Task<string> AddAsync(Event newEvent);
    }
}