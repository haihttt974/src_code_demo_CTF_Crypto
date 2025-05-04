using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _3DES.Models
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext_")
        {
        }

        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Sdt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Users>()
                .Property(e => e.Gmail)
                .IsUnicode(false);
        }
    }
}
