using System.ComponentModel.DataAnnotations;

namespace EventsAPI.Models
{
    public class Ingresso
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public virtual Evento Evento { get; set; }
        public int EventoId { get; set; }
    }
}
