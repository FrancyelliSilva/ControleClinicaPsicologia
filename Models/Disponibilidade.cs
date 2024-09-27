namespace ControleClinicaPsicologia.Models
{
    public class Disponibilidade
    {
        public int Id { get; set; }
        public int PsicologoId { get; set; }
        public DateTime DataHoraDisponivel { get; set; }
        public bool EstaDisponivel { get; set; }

        public Psicologo Psicologo { get; set; }
    }

}
