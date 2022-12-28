namespace correios_integracao.Services.Interfaces
{
    public interface ICorreiosService
    {
        Task<Object> ConsultarCEP(string cep);
        Task<Object> CalcularPrazo(string cdTipoEnvio, string cepOrigem, string cepDestino, string peso, int cdFormato, int comprimento, int altura, int largura, int diametro, string maoPropria, int valorDeclarado, string avisoRecebimento);
    }
}
