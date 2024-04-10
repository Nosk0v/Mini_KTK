using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_KTK.Model
{
    public class Event
    {
        public int Id { get; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime Duration { get; set; }
        public Event(string title, string description, DateTime createDate, DateTime duration)
        {
            Title = title;
            Description = description;
            CreateDate = createDate;
            Duration = duration;
        }
    }
}
