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
    }
}
