using ALTA_TEST.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BAITAP2.Models
{
    public class AppDBContext :DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<BangDiem>().HasKey(o => new { o.MaMH, o.MaHV });
        }

        public DbSet<HocVien> HocVien { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }

        public DbSet<BangDiem> BangDiem { get; set; }
    }
}
