using System.ComponentModel.DataAnnotations;

namespace week8day2.Models
{
    public class Device
    {
        [Key]
        public int DeviceId { get; set; }
        public string DeviceName { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }

    }
}
