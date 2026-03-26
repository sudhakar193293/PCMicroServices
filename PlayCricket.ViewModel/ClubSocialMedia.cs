using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.ViewModel
{
    public class ClubSocialMedia
    {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public List<SocialMedia>? SocialMediaValues { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTimeOffset CreatedAt { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTimeOffset UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
