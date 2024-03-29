﻿namespace correios_integracao.Models
{
    public class Endereco
    {
        public string Cep { get; set; } = string.Empty;
        public string End { get; set; } = string.Empty;
        public string Complemento { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string UF { get; set; } = string.Empty;
        public Object? UnidadePostagem { get; set; } = null;

    }
}
