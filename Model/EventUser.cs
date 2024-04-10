using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_KTK.Model
{
    public class EventUser
    {
        public int UserId { get; set; }
        public int EventId { get; set; }
        public EventUser(int userId, int eventId) 
        {
            UserId = userId;
            EventId = eventId;
        }
    }
}
