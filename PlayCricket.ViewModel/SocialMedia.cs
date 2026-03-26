using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.ViewModel
{
    public class SocialMedia
    {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public int SocialMediaId { get; set; }
        public string SocialMediaName { get; set; } = string.Empty;
        public string SocialMediaValue { get; set; } = string.Empty;
        public string SocialMediaUrl { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTimeOffset CreatedAt { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
