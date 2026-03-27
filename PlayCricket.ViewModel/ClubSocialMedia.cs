using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.ViewModel
{
    public class ClubSocialMedia
    {        
        public int ClubId { get; set; }
        public List<SocialMediaPlatforms>? Platforms { get; set; }
    }
}
