using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.ViewModel
{
    public class SocialMediaPlatforms
    {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public int SocialMediaPlatformId { get; set; }
        public string SocialMediaPlatformName { get; set; } = string.Empty;
        public string SocialMediaPlatformValue { get; set; } = string.Empty;
        public string SocialMediaPlatformUrl { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTimeOffset CreatedAt { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
