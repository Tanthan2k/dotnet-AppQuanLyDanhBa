using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AppQuanLyDanhBa.Model
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext()
            : base("name=AppDBContext2")
        {
        }

        public virtual DbSet<ChiTietNhomLienLac> ChiTietNhomLienLacs { get; set; }
        public virtual DbSet<NhomLienLac> NhomLienLacs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NhomLienLac>()
                .HasMany(e => e.ChiTietNhomLienLacs)
                .WithRequired(e => e.NhomLienLac)
                .HasForeignKey(e => e.IDNhom)
                .WillCascadeOnDelete(false);
        }
    }
}
