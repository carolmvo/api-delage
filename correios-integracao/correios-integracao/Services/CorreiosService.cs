using correios_integracao.Models;
using correios_integracao.Services.Interfaces;
using WSCorreiosPrazo;

namespace correios_integracao.Services
{
    public class CorreiosService : ICorreiosService
    {

        public async Task<Object> CalcularPrazo(string cdTipoEnvio, string cepOrigem, string cepDestino, string peso, int cdFormato, int comprimento, int altura, int largura, int diametro, string maoPropria, int valorDeclarado, string avisoRecebimento)
        {
            using (var ws = new WSCorreiosPrazo.CalcPrecoPrazoWSSoapClient(CalcPrecoPrazoWSSoapClient.EndpointConfiguration.CalcPrecoPrazoWSSoap12))
            {

                var response = await ws.CalcPrecoPrazoAsync(string.Empty, string.Empty, cdTipoEnvio, cepOrigem, cepDestino, peso, cdFormato, comprimento, altura, largura, diametro, maoPropria, valorDeclarado, avisoRecebimento);
                var responseFinal = response.Servicos.FirstOrDefault();

                if (responseFinal != null)
                {
                    //return new { Prazo = responseFinal.PrazoEntrega, Valor = responseFinal.Valor };
                    return responseFinal;
                }

                throw new Exception("Não foi possível encontrar os valores dentro da resposta do serviço");
            }

            
        }

        public async Task<Object> ConsultarCEP(string cep)
        {
            using (var ws = new WSCorreios.AtendeClienteClient())
            {
                
                var response = await ws.consultaCEPAsync(cep);

                try
                {
                    var endereco = new Endereco()
                    {
                        Bairro = response.@return.bairro,
                        Cep = response.@return.cep,
                        Cidade = response.@return.cidade,
                        Complemento = response.@return.complemento2,
                        End = response.@return.end,
                        UF = response.@return.uf,
                        UnidadePostagem = response.@return.unidadesPostagem
                    };

                    return endereco;

                } catch(Exception ex)
                {
                    return new { erro = ex.Message };
                }
            }
        }
    }
}
