using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ControleClinicaPsicologia.Migrations
{
    /// <inheritdoc />
    public partial class AddCRPToPsicologo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Especialidade",
                table: "Psicologos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Pacientes",
                columns: new[] { "PacienteId", "DataNascimento", "PacienteEmail", "PacienteName", "Telefone" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "maria@gmail.com", "Maria Silva", "11987654321" },
                    { 2, new DateTime(1975, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "joao@gmail.com", "João Oliveira", "11981234567" }
                });

            migrationBuilder.InsertData(
                table: "Psicologos",
                columns: new[] { "PsicologoId", "CRP", "Especialidade", "PsicologoNome" },
                values: new object[,]
                {
                    { 1, "06/123456", "Terapia Cognitivo-Comportamental", "Dra. Ana Costa" },
                    { 2, "06/654321", "Psicanálise", "Dr. Carlos Mendes" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pacientes",
                keyColumn: "PacienteId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Psicologos",
                keyColumn: "PsicologoId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "Especialidade",
                table: "Psicologos");
        }
    }
}
