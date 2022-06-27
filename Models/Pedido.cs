namespace EventsAPI.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IngressoId { get; set; }
        public Ingresso Ingresso { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
