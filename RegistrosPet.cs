using System;

namespace PetManager
{
    public class RegistroPet
    {
        public string Tipo { get; set; }
        public string Nome { get; set; }
        public string Raca { get; set; }
        public DateTime Nascimento { get; set; }
        public string Cor { get; set; }
        public string Pelagem { get; set; }
        public string Castrado { get; set; }
        public string Peso { get; set; }
        public string Porte { get; set; }
        public string Vacinas { get; set; }
        public string Observacoes { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public string Resumo { get; set; }
    }
}