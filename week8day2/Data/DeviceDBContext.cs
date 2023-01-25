using Microsoft.EntityFrameworkCore;
using week8day2.Models;

namespace week8day2.Data
{
    public class DeviceDBContext : DbContext
    {
        public DeviceDBContext(DbContextOptions<DeviceDBContext> options) : base(options)
        {
        }

        public DbSet<Device> Devices { get; set; }
    }
}
