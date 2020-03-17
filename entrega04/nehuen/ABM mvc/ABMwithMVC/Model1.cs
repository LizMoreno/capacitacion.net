 namespace ABMwithMVC
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<SEG_Users> SEG_Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SEG_Users>()
                .Property(e => e.DisplayName)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_Users>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<SEG_Users>()
                .Property(e => e.Password)
                .IsUnicode(false);
        }
    }
}
