﻿// <auto-generated />
using System;
using ControleClinicaPsicologia.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleClinicaPsicologia.Migrations
{
    [DbContext(typeof(ControleClinicaPsicologiaContext))]
    [Migration("20240910235631_AddCRPToPsicologo")]
    partial class AddCRPToPsicologo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ControleClinicaPsicologia.Models.Consulta", b =>
                {
                    b.Property<int>("ConsultaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ConsultaId"));

                    b.Property<DateTime>("DataConsulta")
                        .HasColumnType("datetime2");

                    b.Property<string>("Observacoes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<int>("PsicologoId")
                        .HasColumnType("int");

                    b.HasKey("ConsultaId");

                    b.HasIndex("PacienteId");

                    b.HasIndex("PsicologoId");

                    b.ToTable("Consultas");
                });

            modelBuilder.Entity("ControleClinicaPsicologia.Models.Paciente", b =>
                {
                    b.Property<int>("PacienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PacienteId"));

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("PacienteEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PacienteName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PacienteId");

                    b.ToTable("Pacientes");

                    b.HasData(
                        new
                        {
                            PacienteId = 1,
                            DataNascimento = new DateTime(1980, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PacienteEmail = "maria@gmail.com",
                            PacienteName = "Maria Silva",
                            Telefone = "11987654321"
                        },
                        new
                        {
                            PacienteId = 2,
                            DataNascimento = new DateTime(1975, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PacienteEmail = "joao@gmail.com",
                            PacienteName = "João Oliveira",
                            Telefone = "11981234567"
                        });
                });

            modelBuilder.Entity("ControleClinicaPsicologia.Models.Psicologo", b =>
                {
                    b.Property<int>("PsicologoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PsicologoId"));

                    b.Property<string>("CRP")
                        .IsRequired()
                        .HasMaxLength(7)
                        .HasColumnType("nvarchar(7)");

                    b.Property<string>("Especialidade")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PsicologoNome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PsicologoId");

                    b.ToTable("Psicologos");

                    b.HasData(
                        new
                        {
                            PsicologoId = 1,
                            CRP = "06/123456",
                            Especialidade = "Terapia Cognitivo-Comportamental",
                            PsicologoNome = "Dra. Ana Costa"
                        },
                        new
                        {
                            PsicologoId = 2,
                            CRP = "06/654321",
                            Especialidade = "Psicanálise",
                            PsicologoNome = "Dr. Carlos Mendes"
                        });
                });

            modelBuilder.Entity("ControleClinicaPsicologia.Models.Consulta", b =>
                {
                    b.HasOne("ControleClinicaPsicologia.Models.Paciente", "Paciente")
                        .WithMany()
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ControleClinicaPsicologia.Models.Psicologo", "Psicologo")
                        .WithMany()
                        .HasForeignKey("PsicologoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");

                    b.Navigation("Psicologo");
                });
#pragma warning restore 612, 618
        }
    }
}
