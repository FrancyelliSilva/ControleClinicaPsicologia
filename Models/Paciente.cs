using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleClinicaPsicologia.Models
{
    public class Paciente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PacienteId { get; set; }

        [Required]
        [StringLength(100)]
        public string PacienteName { get;set; }

        [Required]
        [EmailAddress]
        public string PacienteEmail { get; set; }

        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Phone]
        public string Telefone { get; set; }

        public string Prontuario { get; set; }
    }
}
