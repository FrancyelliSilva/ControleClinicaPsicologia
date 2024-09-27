using System;
using System.ComponentModel.DataAnnotations;

namespace ControleClinicaPsicologia.Models
{
    public class Consulta
    {
        public int ConsultaId { get; set; }
        public required string PacienteNome { get; set; }
        public required string PsicologoNome { get; set; }


        public required string Telefone { get; set; }
        public DateTime DataConsulta { get; set; }
        public string Observacoes { get; set; }
    }

}
