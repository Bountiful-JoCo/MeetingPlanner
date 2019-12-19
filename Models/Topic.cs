using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingPlanner.Models
{
    public partial class Topic: Meeting
    {
       

        public string TopicName { get; set; }
        public DateTime Date { get; set; }

        public ICollection<Meeting>Meetings { get; set; }

    }
}
