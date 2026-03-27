using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.ViewModel
{
    public class ClubColor
    {              
        public int ClubId { get; set; }
        public Colors ClubColors { get; set; } = new Colors();
        public string ClubBadgeImageName { get; set; } = string.Empty;
        public string ClubBadgeContentType { get; set; } = string.Empty;
        public byte[] ClubBadgeImageData { get; set; } = Array.Empty<byte>();
        public int ClubBadgeImageSize { get; set; }
        public string ChecksumSha256 { get; set; } = default!;
        public string ClubBadgeOutlineColor { get; set; } = string.Empty;
        public string CreatedBy { get; set; }= string.Empty;
        public DateTimeOffset CreatedAt { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTimeOffset UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
