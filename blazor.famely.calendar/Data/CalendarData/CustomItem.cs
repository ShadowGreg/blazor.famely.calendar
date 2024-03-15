using Heron.MudCalendar;
using MudBlazor;

namespace blazor.famely.calendar.Data.CalendarData
{
    public class CustomItem : CalendarItem
    {
        public string Title { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public Color Color { get; set; } = Color.Primary;
    }
}