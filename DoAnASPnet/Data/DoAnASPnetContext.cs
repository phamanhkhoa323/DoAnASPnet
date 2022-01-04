using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DoAnASPnet.Models;

namespace DoAnASPnet.Data
{
    public class DoAnASPnetContext : DbContext
    {
        public DoAnASPnetContext (DbContextOptions<DoAnASPnetContext> options)
            : base(options)
        {
        }

        public DbSet<DoAnASPnet.Models.Nguoidung> Nguoidung { get; set; }

        public DbSet<DoAnASPnet.Models.Donhang> Donhang { get; set; }

        public DbSet<DoAnASPnet.Models.Chitietdonhang> Chitietdonhang { get; set; }

        public DbSet<DoAnASPnet.Models.Hangsanxuat> Hangsanxuat { get; set; }

        public DbSet<DoAnASPnet.Models.Hedieuhanh> Hedieuhanh { get; set; }

        public DbSet<DoAnASPnet.Models.Phanquyen> Phanquyen { get; set; }

        public DbSet<DoAnASPnet.Models.Sanpham> Sanpham { get; set; }
    }
}
