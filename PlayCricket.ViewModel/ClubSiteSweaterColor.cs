using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.ViewModel
{
    public class ClubSiteSweaterColor
    {
        public int Id { get; set; }        
        public int ClubSiteSweaterColorId { get; set; }
        public string ClubSiteSweaterColorValue { get; set; } = string.Empty;
        public PlayCricketAudit Audit { get; set; } = new PlayCricketAudit();
        public PlayCricketStatus Status { get; set; } = new PlayCricketStatus();
    }
}
