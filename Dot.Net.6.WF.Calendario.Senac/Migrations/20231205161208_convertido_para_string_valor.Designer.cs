﻿// <auto-generated />
using System;
using Dot.Net._6.WF.Calendario.Senac;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dot.Net._6.WF.Calendario.Senac.Migrations
{
    [DbContext(typeof(BancoDeDados))]
    [Migration("20231205161208_convertido_para_string_valor")]
    partial class convertido_para_string_valor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.25");

            modelBuilder.Entity("Dot.Net._6.WF.Calendario.Senac.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Dias")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fim")
                        .HasColumnType("TEXT");

                    b.Property<string>("Horario")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Inicio")
                        .HasColumnType("TEXT");

                    b.Property<string>("Meta")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("TEXT");

                    b.Property<string>("Realizado")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sala")
                        .HasColumnType("TEXT");

                    b.Property<string>("Turma")
                        .HasColumnType("TEXT");

                    b.Property<string>("Turno")
                        .HasColumnType("TEXT");

                    b.Property<string>("Valor")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Cursos");
                });
#pragma warning restore 612, 618
        }
    }
}
