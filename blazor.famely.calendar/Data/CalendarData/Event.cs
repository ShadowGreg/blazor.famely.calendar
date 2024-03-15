using System.ComponentModel.DataAnnotations;
using Heron.MudCalendar;
using MudBlazor;

namespace blazor.famely.calendar.Data.CalendarData
{
    public class Event : CalendarItem
    {
        public string Master { get; set; } = String.Empty;
        public string Title { get; set; } = String.Empty;
        public string Location { get; set; } = String.Empty;
        public Color Color { get; set; } = Color.Primary;

        [Key]
        public string IdKey
        {
            get => Id;
            set => IdKey = value;
        }
    }
}