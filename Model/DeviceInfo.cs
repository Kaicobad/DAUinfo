using System.ComponentModel.DataAnnotations;

namespace DAUinfo.Model
{
    public class DeviceInfo
    {
        [Key]
        public int Id { get; set; }
        public string DeviceType { get; set; }
        public string ScreenSize { get; set; }
        public string Os { get; set; }
        public string Ip { get; set; }
    }
}
