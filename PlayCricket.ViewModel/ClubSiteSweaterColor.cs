using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.ViewModel
{
    public class ClubSiteSweaterColor
    {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public int ClubSiteSweaterColorId { get; set; }
        public string ClubSiteSweaterColorValue { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTimeOffset CreatedAt { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTimeOffset UpdatedAt { get; set; }
    }
}
