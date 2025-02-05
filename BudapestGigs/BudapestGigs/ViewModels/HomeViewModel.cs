﻿using BudapestGigs.Models;
using System.Collections.Generic;

namespace BudapestGigs.ViewModels
{
    public class GigsViewModel
    {
        public IEnumerable<Gig> UpcomingGigs { get; set; }
        public bool ShowActions { get; set; }
        public string Heading { get; set; }
    }
}