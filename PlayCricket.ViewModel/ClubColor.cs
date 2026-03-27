using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.ViewModel
{
    public class ClubColor
    {              
        public int ClubId { get; set; }
        public Colors ClubColors { get; set; } = new Colors();
        public BadgeBranding Branding { get; set; } = new BadgeBranding();        
    }
}
