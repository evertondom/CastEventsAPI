using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EventsAPI.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IngressosDisponiveis { get; set; }
        public string ImagemUrl { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public double ValorIngresso { get; set; }
        [JsonIgnore]
        public virtual IList<Ingresso> Ingressos { get; set; }
    }
}
