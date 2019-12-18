using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MeetingPlanner.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MeetingPlanner.Pages.Meetings
{
    public class IndexModel : PageModel
    {
        private readonly MeetingPlanner.Models.MeetingPlannerContext _context;

        public IndexModel(MeetingPlanner.Models.MeetingPlannerContext context)
        {
            _context = context;
        }

        public IList<Meeting> Meeting { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Topics { get; set; }
        [BindProperty(SupportsGet =true)]
        public string MeetingTopic { get; set; }
        public string DateSort { get; set; }
        public string SortOrder { get; set; }

        public async Task OnGetAsync(string SearchString, string SortOrder)
        {
            IQueryable<string> topicQuery = from t in _context.Meeting
                                            orderby t.SpeechDate
                                            select t.Topic;
            var meetings = from m in _context.Meeting
                           select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                meetings = meetings.Where(s => s.Speaker1.Contains(SearchString)||
                                               s.Speaker2.Contains(SearchString)||
                                               s.Speaker3.Contains(SearchString)||
                                               s.Speaker4.Contains(SearchString)||
                                               s.Speaker5.Contains(SearchString));
            }
            if (!string.IsNullOrEmpty(MeetingTopic))
            {
                meetings = meetings.Where(x => x.Topic==MeetingTopic);
            }
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


            Topics = new SelectList(await topicQuery.Distinct().ToListAsync());
            Meeting = await meetings.AsNoTracking().ToListAsync();
        }
    }
}
