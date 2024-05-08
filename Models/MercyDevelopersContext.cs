using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace mercy_developers.Models;

public partial class MercyDevelopersContext : DbContext
{
    public MercyDevelopersContext()
    {
    }

    public MercyDevelopersContext(DbContextOptions<MercyDevelopersContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ClienteServicio> ClienteServicios { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

        }
    }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseMySql("server=localhost;port=3306;database=mercy_developers;uid=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.24-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8_general_ci")
            .HasCharSet("utf8");

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Idcliente).HasName("PRIMARY");

            entity.ToTable("cliente");

            entity.Property(e => e.Idcliente)
                .HasColumnType("int(11)")
                .HasColumnName("idcliente");
            entity.Property(e => e.Apellido)
                .HasMaxLength(45)
                .HasColumnName("apellido");
            entity.Property(e => e.Correo)
                .HasMaxLength(45)
                .HasColumnName("correo");
            entity.Property(e => e.Direccion)
                .HasMaxLength(45)
                .HasColumnName("direccion");
            entity.Property(e => e.Nombre)
                .HasMaxLength(45)
                .HasColumnName("nombre");
            entity.Property(e => e.Telefono)
                .HasMaxLength(45)
                .HasColumnName("telefono");
        });

        modelBuilder.Entity<ClienteServicio>(entity =>
        {
            entity.HasKey(e => e.IdclienteServicio).HasName("PRIMARY");

            entity.ToTable("cliente_servicio");

            entity.Property(e => e.IdclienteServicio)
                .HasColumnType("int(11)")
                .HasColumnName("idcliente_servicio");
            entity.Property(e => e.ClienteServiciocol)
                .HasColumnType("int(11)")
                .HasColumnName("cliente_serviciocol");
            entity.Property(e => e.FechaServicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_servicio");
            entity.Property(e => e.Idservicio)
                .HasColumnType("int(11)")
                .HasColumnName("idservicio");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.Idservicio).HasName("PRIMARY");

            entity.ToTable("servicio");

            entity.Property(e => e.Idservicio)
                .HasColumnType("int(11)")
                .HasColumnName("idservicio");
            entity.Property(e => e.Diagnostico)
                .HasMaxLength(45)
                .HasColumnName("diagnostico");
            entity.Property(e => e.FechaInicio)
                .HasColumnType("datetime")
                .HasColumnName("fecha_inicio");
            entity.Property(e => e.FechaTermino)
                .HasColumnType("datetime")
                .HasColumnName("fecha_termino");
            entity.Property(e => e.Idcliente)
                .HasColumnType("int(11)")
                .HasColumnName("idcliente");
            entity.Property(e => e.Mantenimiento)
                .HasMaxLength(45)
                .HasColumnName("mantenimiento");
            entity.Property(e => e.Nombre)
                .HasMaxLength(45)
                .HasColumnName("nombre");
            entity.Property(e => e.ReinstalarInstalarSowfware)
                .HasMaxLength(45)
                .HasColumnName("reinstalar_instalar_sowfware");
            entity.Property(e => e.RepararReemplazar)
                .HasMaxLength(45)
                .HasColumnName("reparar_reemplazar");
            entity.Property(e => e.Valor)
                .HasMaxLength(45)
                .HasColumnName("valor");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
