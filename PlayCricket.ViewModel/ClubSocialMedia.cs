using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.ViewModel
{
    public class ClubSocialMedia
    {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public List<SocialMediaPlatforms>? SocialMediaPlatforms { get; set; }
    }
}
