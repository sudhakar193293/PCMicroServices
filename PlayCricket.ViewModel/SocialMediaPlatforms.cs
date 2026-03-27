using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.ViewModel
{
    public class SocialMediaPlatforms
    {        
        public SocialPlatform Platform { get; set; } = new SocialPlatform();
        public string Value { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
        public PlayCricketStatus Status { get; set; } = new PlayCricketStatus();
        public PlayCricketAudit Audit { get; set; } = new PlayCricketAudit();        
    }
    public class SocialPlatform
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

    }
}
