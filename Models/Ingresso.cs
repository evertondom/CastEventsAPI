namespace EventsAPI.Models
{
    public class Ingresso
    {
        public int Id { get; set; }
        public string Area { get; set; }
        public string Posicao { get; set; }
        public double ValorIngresso { get; set; }
        public int EventoId { get; set; }
        public Evento Evento { get; set; }
    }
}
