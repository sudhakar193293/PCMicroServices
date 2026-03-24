using System;
using System.Collections.Generic;
using System.Text;

namespace PlayCricket.ViewModel
{
    public class ClubColor
    {
        public int Id { get; set; }
        public int ClubId { get; set; }
        public string ClubSiteHeaderColorPrimary { get; set; } = string.Empty;
        public string ClubSiteHeaderColorSeconday { get; set; } = string.Empty;
        public string ClubSiteHeaderColorTertiary { get; set; } = string.Empty;
        public string ClubSiteSweaterColorPrimary { get; set; } = string.Empty;
        public string ClubSiteSweaterColorSecondary { get; set; } = string.Empty;
        public string ClubSiteSweaterColorTertiary { get; set; } = string.Empty;
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
    }
}
