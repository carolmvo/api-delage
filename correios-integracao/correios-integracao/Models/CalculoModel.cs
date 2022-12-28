namespace correios_integracao.Models
{
    public class CalculoModel
    {
        public string servico { get; set; }
        public string cepOrigem { get; set; }
        public string cepDestino { get; set; }
        public string peso { get; set; }
        public int formato { get; set; }
        public int comprimento { get; set; }
        public int altura { get; set; }
        public int largura { get; set; }
        public int diametro { get; set; }
        public int valorDeclarado { get; set; }
        public string maoPropria { get; set; }
        public string avisoRecebimento { get; set; }
    }
}
