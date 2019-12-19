using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MeetingPlanner.Models;

namespace MeetingPlanner.Models
{
    public class MeetingPlannerContext : DbContext
    {
        public MeetingPlannerContext (DbContextOptions<MeetingPlannerContext> options)
            : base(options)
        {
        }

        public DbSet<MeetingPlanner.Models.Meeting> Meeting { get; set; }

        public DbSet<MeetingPlanner.Models.Topic> Topic { get; set; }

        public DbSet<MeetingPlanner.Models.Speaker> Speaker { get; set; }
    }
}
