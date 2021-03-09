using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Information.Models
{
    public partial class SinhVienDbContext : DbContext
    {
        public SinhVienDbContext()
            : base("name=SinhVienDbContext")
        {
        }

        public virtual DbSet<Thongtin> thongtin { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
