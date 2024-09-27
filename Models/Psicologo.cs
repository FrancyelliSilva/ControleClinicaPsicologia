using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ControleClinicaPsicologia.Models
{
    public class Psicologo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PsicologoId { get; set; }

        [Required]
        [StringLength(100)]
        public string PsicologoNome { get; set; }

        [StringLength(100)]
        public string Especialidade { get; set; }

        [Required]
        [StringLength(8)]
        public string NumeroRegistro { get;set; }

        [Required]
        public string Telefone { get; set; }


    }
}
