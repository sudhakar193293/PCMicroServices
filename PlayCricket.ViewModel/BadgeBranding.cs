using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.ViewModel
{
    public class BadgeBranding
    {
        public string ClubBadgeImageName { get; set; } = string.Empty;
        public string ClubBadgeContentType { get; set; } = string.Empty;
        public byte[] ClubBadgeImageData { get; set; } = Array.Empty<byte>();
        public int ClubBadgeImageSize { get; set; }
        public string ChecksumSha256 { get; set; } = default!;
        public string ClubBadgeOutlineColor { get; set; } = string.Empty;
        public PlayCricketAudit Audit { get; set; } = new PlayCricketAudit();
        public PlayCricketStatus Status { get; set; } = new PlayCricketStatus();
    }
}
