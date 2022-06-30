namespace EventsAPI.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IngressoId { get; set; }
        public virtual Ingresso Ingresso { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
