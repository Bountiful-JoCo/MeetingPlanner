using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MeetingPlanner.Models
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MeetingPlannerContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MeetingPlannerContext>>()))
            {
                if (context.Meeting.Any())
                {
                    return;
                }

                context.Meeting.AddRange(
                    new Meeting
                    {
                        SpeechDate = DateTime.Parse("2018-09-01"),
                        Topic = "Faith",
                        ConductingLeader = "John Smith",
                        OpeningSong = "The Morning Breaks",
                        OpeningPrayer = "Jane Doe",
                        SacramentSong = "The Spirit of God",
                        Speaker1 = "Mark Daniels",
                        Speaker2 = "John Doe",
                        Speaker3 = "",
                        Speaker4 = "Abby Normal",
                        Speaker5 = "",
                        ClosingSong = "Now Let Us Rejoice",
                        ClosingPrayer = "Jack Frost"
                    });

                context.SaveChanges();
            }
            
        }
    }
} 
