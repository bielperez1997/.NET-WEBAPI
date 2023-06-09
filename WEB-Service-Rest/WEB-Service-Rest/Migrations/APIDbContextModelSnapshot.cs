﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WEB_Service_Rest.Data;

#nullable disable

namespace WEB_Service_Rest.Migrations
{
    [DbContext(typeof(APIDbContext))]
    partial class APIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("WEB_Service_Rest.Models.Cliente", b =>
                {
                    b.Property<string>("ClienteID")
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.Property<string>("ClienteName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("ClienteID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("WEB_Service_Rest.Models.Conta", b =>
                {
                    b.Property<int>("IdConta")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<string>("TipoConta")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("IdConta");

                    b.ToTable("Conta");
                });

            modelBuilder.Entity("WEB_Service_Rest.Models.Saldo", b =>
                {
                    b.Property<int>("IdSaldo")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(200)
                        .HasColumnType("int");

                    b.Property<string>("SaldoConta")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("IdSaldo");

                    b.ToTable("Saldo");
                });
#pragma warning restore 612, 618
        }
    }
}
