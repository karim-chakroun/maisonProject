﻿// <auto-generated />
using Examen.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Examen.Data.Migrations
{
    [DbContext(typeof(ExamContext))]
    partial class ExamContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Examen.Domain.Entities.Maison", b =>
                {
                    b.Property<int>("maisonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("prix")
                        .HasColumnType("float");

                    b.Property<string>("quartiers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("typeFk")
                        .HasColumnType("int");

                    b.HasKey("maisonId");

                    b.HasIndex("typeFk");

                    b.ToTable("Maisons");
                });

            modelBuilder.Entity("Examen.Domain.Entities.TypeMaison", b =>
                {
                    b.Property<int>("typeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("typeId");

                    b.ToTable("Types");
                });

            modelBuilder.Entity("Examen.Domain.Entities.Maison", b =>
                {
                    b.HasOne("Examen.Domain.Entities.TypeMaison", "type")
                        .WithMany("maisons")
                        .HasForeignKey("typeFk")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("type");
                });

            modelBuilder.Entity("Examen.Domain.Entities.TypeMaison", b =>
                {
                    b.Navigation("maisons");
                });
#pragma warning restore 612, 618
        }
    }
}