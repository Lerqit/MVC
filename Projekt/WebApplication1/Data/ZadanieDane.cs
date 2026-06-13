using Microsoft.EntityFrameworkCore;
using ZadaniaDomowe.Models;

namespace ZadaniaDomowe.Data
{
    public class ZadanieDane : DbContext
    {
        public ZadanieDane(DbContextOptions<ZadanieDane> options)
            : base(options)
        {
        }

        public DbSet<Zadanie> Zadanie { get; set; }
    }
}