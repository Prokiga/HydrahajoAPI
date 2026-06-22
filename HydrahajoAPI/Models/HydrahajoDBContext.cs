using Microsoft.EntityFrameworkCore;

namespace HydrahajoAPI.Models
{
    public class HydrahajoDBContext : DbContext
    {
        public HydrahajoDBContext()
        {

        }


        public HydrahajoDBContext(DbContextOptions<HydrahajoDBContext> options) : base(options)
        {

        }

        public DbSet<Component> components { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=localhost; Database=Hydrahajo; Uid=root; Pwd=;");
        }
}
}
