using System.ComponentModel.DataAnnotations;
using Heron.MudCalendar;
using MudBlazor;

namespace blazor.famely.calendar.Data.CalendarData
{
    public class Event : CalendarItem
    {
        private string _idKey;

        public Event()
        {
            _idKey = Id;
        }

        public string Master { get; set; } = String.Empty;
        public string Title { get; set; } = String.Empty;
        public string Location { get; set; } = String.Empty;
        public Color Color { get; set; } = Color.Primary;

        [Key]
        public string IdKey
        {
            get => _idKey;
            set => _idKey = value;
        }

        public string IsActually { get; set; } = String.Empty;
    }
}