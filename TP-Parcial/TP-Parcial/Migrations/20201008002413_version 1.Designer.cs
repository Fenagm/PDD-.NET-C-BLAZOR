﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP_Parcial;

namespace TP_Parcial.Migrations
{
    [DbContext(typeof(TareasDbcontext))]
    [Migration("20201008002413_version 1")]
    partial class version1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("TP_Parcial.Detalles", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("recursosId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("tareasId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("tiempo")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("recursosId");

                    b.HasIndex("tareasId");

                    b.ToTable("Detalles");
                });

            modelBuilder.Entity("TP_Parcial.Recursos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuariosId")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("UsuariosId");

                    b.ToTable("Recursos");
                });

            modelBuilder.Entity("TP_Parcial.Tareas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("estado")
                        .HasColumnType("TEXT");

                    b.Property<int>("estimacion")
                        .HasColumnType("INTEGER");

                    b.Property<int>("recursosId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("titulo")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("vencimiento")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("recursosId");

                    b.ToTable("Tareas");
                });

            modelBuilder.Entity("TP_Parcial.Usuarios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .HasColumnType("TEXT");

                    b.Property<string>("Usuario")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("TP_Parcial.Detalles", b =>
                {
                    b.HasOne("TP_Parcial.Recursos", "recurso")
                        .WithMany()
                        .HasForeignKey("recursosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP_Parcial.Tareas", "tarea")
                        .WithMany()
                        .HasForeignKey("tareasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TP_Parcial.Recursos", b =>
                {
                    b.HasOne("TP_Parcial.Usuarios", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuariosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TP_Parcial.Tareas", b =>
                {
                    b.HasOne("TP_Parcial.Recursos", "responsable")
                        .WithMany()
                        .HasForeignKey("recursosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
