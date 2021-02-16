namespace ExamenU2Web2_Lizarraga.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Datos : DbContext
    {
        public Datos()
            : base("name=Datos")
        {
        }

        public virtual DbSet<Operacion> Operacion { get; set; }
        public virtual DbSet<TipoOperacion> TipoOperacion { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Operacion>()
                .Property(e => e.operador1)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.operador2)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.resultado)
                .HasPrecision(5, 2);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoOperacion>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TipoOperacion>()
                .Property(e => e.estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoOperacion>()
                .HasMany(e => e.Operacion)
                .WithRequired(e => e.TipoOperacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.usuario1)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.clave)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.rol)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.estado)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
