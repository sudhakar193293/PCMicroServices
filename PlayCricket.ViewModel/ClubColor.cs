using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.ViewModel
{
    public class ClubColor
    {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public List<ClubSiteHeaderColor>? ClubSiteHeaderColors { get; set; }
        public List<ClubSiteSweaterColor>? ClubSiteSweaterColors { get; set; }
        public string ClubBatchImageName { get; set; } = string.Empty;
        public string ClubBatchContentType { get; set; } = string.Empty;
        public byte[] ClubBatchImageData { get; set; } = Array.Empty<byte>();
        public int ClubBatchImageSize { get; set; }
        public string ChecksumSha256 { get; set; } = default!;
        public string ClubBatchOutlineColor { get; set; } = string.Empty;
        public string CreatedBy { get; set; }= string.Empty;
        public DateTimeOffset CreatedAt { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTimeOffset UpdatedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
