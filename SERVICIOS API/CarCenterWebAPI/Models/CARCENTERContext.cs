using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace CarCenterWebAPI.Models
{
    public partial class CARCENTERContext : DbContext
    {
        public CARCENTERContext()
        {
        }

        public CARCENTERContext(DbContextOptions<CARCENTERContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<FactDetalleRepuesto> FactDetalleRepuestos { get; set; }
        public virtual DbSet<FactDetalleServicio> FactDetalleServicios { get; set; }
        public virtual DbSet<FacturaEmcabezado> FacturaEmcabezados { get; set; }
        public virtual DbSet<Mecanico> Mecanicos { get; set; }
        public virtual DbSet<Repuesto> Repuestos { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-5UOTS7F\\SQLEXPRESS2019;Database=CARCENTER;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.Documento);

                entity.Property(e => e.Documento).HasMaxLength(30);

                entity.Property(e => e.CorreoElectronico).HasMaxLength(100);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NoCelular)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.SegundoApellido).HasMaxLength(60);

                entity.Property(e => e.SegundoNombre).HasMaxLength(40);

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<FactDetalleRepuesto>(entity =>
            {
                entity.HasKey(e => new { e.FacturaNo, e.IdRepuesto });

                entity.Property(e => e.FacturaNo).HasMaxLength(30);

                entity.Property(e => e.Cantidad).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.Sucursal)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ValorTotal).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.ValorUnitario).HasColumnType("decimal(20, 2)");
            });

            modelBuilder.Entity<FactDetalleServicio>(entity =>
            {
                entity.HasKey(e => new { e.FacturaNo, e.IdServicio });

                entity.Property(e => e.FacturaNo).HasMaxLength(30);

                entity.Property(e => e.Sucursal)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ValorDescuento).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.ValorTotal).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.ValorUnitario).HasColumnType("decimal(20, 2)");
            });

            modelBuilder.Entity<FacturaEmcabezado>(entity =>
            {
                entity.HasKey(e => e.FacturaNo);

                entity.ToTable("FacturaEmcabezado");

                entity.Property(e => e.FacturaNo).HasMaxLength(30);

                entity.Property(e => e.DocumentoCliente)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.DocumentoMecanico)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.PresupuestoCliente).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.Sucursal)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ValorIva)
                    .HasColumnType("decimal(20, 2)")
                    .HasColumnName("ValorIVA");

                entity.Property(e => e.ValorSubTotal).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.ValorTotalDescuento).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.ValorTotalFactura).HasColumnType("decimal(20, 2)");
            });

            modelBuilder.Entity<Mecanico>(entity =>
            {
                entity.HasKey(e => e.Documento);

                entity.Property(e => e.Documento).HasMaxLength(30);

                entity.Property(e => e.CorreoElectronico).HasMaxLength(100);

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(40)
                    .HasDefaultValueSql("('Iniciar')");

                entity.Property(e => e.NoCelular)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(60);

                entity.Property(e => e.PrimerNombre)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.SegundoApellido).HasMaxLength(60);

                entity.Property(e => e.SegundoNombre).HasMaxLength(40);

                entity.Property(e => e.TipoDocumento)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Repuesto>(entity =>
            {
                entity.HasKey(e => e.IdRepuesto);

                entity.Property(e => e.IdRepuesto).ValueGeneratedNever();

                entity.Property(e => e.DescripcionRepuesto)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ValorUnitario).HasColumnType("decimal(20, 2)");
            });

            modelBuilder.Entity<Servicio>(entity =>
            {
                entity.HasKey(e => e.IdServicio);

                entity.Property(e => e.IdServicio).ValueGeneratedNever();

                entity.Property(e => e.DescripcionServicio)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ValorManoDeObra).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.ValorMaximo).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.ValorMinimo).HasColumnType("decimal(20, 2)");
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.HasKey(e => e.TipoDocumento1);

                entity.Property(e => e.TipoDocumento1)
                    .HasMaxLength(10)
                    .HasColumnName("TipoDocumento");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(60);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
