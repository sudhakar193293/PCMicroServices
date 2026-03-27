using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.ViewModel
{
    public class ClubSiteHeaderColor
    {
        public int Id { get; set; }        
        public int ClubSiteHeaderColorId { get; set; }
        public string ClubSiteHeaderColorValue { get; set; } = string.Empty;
        public PlayCricketAudit Audit { get; set; } = new PlayCricketAudit();
        public PlayCricketStatus Status { get; set; } = new PlayCricketStatus();
    }
}
