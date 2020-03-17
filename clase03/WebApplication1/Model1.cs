namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ModelTest")
        {
        }

        public virtual DbSet<Operacione> Operaciones { get; set; }
        public virtual DbSet<SEG_Users> SEG_Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Operacione>()
                .Property(e => e.order_id)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.account)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.symbol)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.transact_time)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.side)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.ord_type)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.order_price)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.order_size)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.exec_inst)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.time_in_force)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.expire_date)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.stop_px)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.last_cl_ord_id)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.text)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.exec_type)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.ord_status)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.last_price)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.last_qty)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.avg_price)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.cum_qty)
                .IsUnicode(false);

            modelBuilder.Entity<Operacione>()
                .Property(e => e.leaves_qty)
                .IsUnicode(false);

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
