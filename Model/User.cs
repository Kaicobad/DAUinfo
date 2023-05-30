using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Security.Cryptography;

namespace DAUinfo.Model
{
    public class User
    {
        [Key]
        public int? Id { get; set; }
        public string? Msisdn { get; set; } = string.Empty;
        public string? Name { get; set; } = string.Empty;
        public string? Dob { get; set; } = string.Empty;
        public string? Gender { get; set; } = string.Empty;
        public string? Email { get; set; } = string.Empty;
        public string? Location { get; set; } = string.Empty;
        public string? DeviceType { get; set; } = string.Empty;
        public string? ScreenSize { get; set; } = string.Empty;
        public string? Os { get; set; } = string.Empty;
        public string? Ip { get; set; } = string.Empty;
    }
}
