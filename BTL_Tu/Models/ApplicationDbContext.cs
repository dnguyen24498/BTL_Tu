using Microsoft.EntityFrameworkCore;

namespace BTL_Tu.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<HocSinh> HocSinhs { get; set; }
        public DbSet<HoSo> HoSos { get; set; }
        public DbSet<PhuHuynh> PhuHuynhs { get; set; }
    }
}
