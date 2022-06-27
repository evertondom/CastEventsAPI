using System;

namespace EventsAPI.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int CapacidadeTotal { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public int GeneroId { get; set; }
        public Genero Genero { get; set; }
    }
}
