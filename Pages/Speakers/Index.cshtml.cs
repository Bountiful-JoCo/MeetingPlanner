﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MeetingPlanner.Models;

namespace MeetingPlanner.Pages.Speakers
{
    public class IndexModel : PageModel
    {
        private readonly MeetingPlanner.Models.MeetingPlannerContext _context;

        public IndexModel(MeetingPlanner.Models.MeetingPlannerContext context)
        {
            _context = context;
        }

        public IList<Speaker> Speaker { get; set; }
        public IList<Meeting> Meeting { get; set; }
        public string DateSort { get; set; }
        public string SortOrder { get; set; }
        [BindProperty(SupportsGet = true)]
        public string MeetingTopic { get; set; }

        public async Task OnGetAsync(string SortOrder)
        {
            var meetings = from m in _context.Meeting
                           select m;

            DateSort = SortOrder == "Date" ? "date_desc" : "Date";
            switch (SortOrder)
            {

                case "Date":
                    meetings = meetings.OrderBy(sc => sc.SpeechDate);
                    break;
                case "date_desc":
                    meetings = meetings.OrderByDescending(sc => sc.SpeechDate);
                    break;

            }


            // Topic = await _context.Topic.ToListAsync();
            Meeting = await meetings.AsNoTracking().ToListAsync();
        }
    }
}
