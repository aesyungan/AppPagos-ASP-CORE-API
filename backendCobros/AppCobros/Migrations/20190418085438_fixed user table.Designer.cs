﻿// <auto-generated />
using AppCobros.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppCobros.Migrations
{
    [DbContext(typeof(PaymentDetailContext))]
    [Migration("20190418085438_fixed user table")]
    partial class fixedusertable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AppCobros.Models.PaymentDetail", b =>
                {
                    b.Property<int>("PMId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CardNumber")
                        .IsRequired()
                        .HasMaxLength(16);

                    b.Property<string>("CardOwnerName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ExpirationDate")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<int>("UsuarioId");

                    b.Property<string>("cvv")
                        .IsRequired()
                        .HasMaxLength(3);

                    b.HasKey("PMId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("PaymentDetails");
                });

            modelBuilder.Entity("AppCobros.Models.User", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("edad");

                    b.Property<string>("genero")
                        .HasMaxLength(100);

                    b.HasKey("UsuarioId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("AppCobros.Models.PaymentDetail", b =>
                {
                    b.HasOne("AppCobros.Models.User", "Usuario")
                        .WithMany("paymentDetails")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
