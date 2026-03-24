using System.ComponentModel.DataAnnotations;
namespace PlayCricket.Services.Controllers.Model
{
    public class UserDetails
    {
        [Key]
        public int id { get; set; }
        public string firstname { get; set; } = string.Empty;
        public string lastname { get; set; } = string.Empty;
        public string gender { get; set; } = string.Empty;
    }
}
