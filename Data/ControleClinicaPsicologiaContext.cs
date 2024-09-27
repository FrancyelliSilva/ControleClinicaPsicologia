using Microsoft.EntityFrameworkCore;
using ControleClinicaPsicologia.Models;

namespace ControleClinicaPsicologia.Data
{
    public class ControleClinicaPsicologiaContext : DbContext
    {
        public ControleClinicaPsicologiaContext(DbContextOptions<ControleClinicaPsicologiaContext> options) : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Psicologo> Psicologos { get; set; }
        public DbSet<Consulta> Consultas { get; set; }

        public async Task SaveChangeAsync()
        {
            throw new NotImplementedException();
        }
    }

}
