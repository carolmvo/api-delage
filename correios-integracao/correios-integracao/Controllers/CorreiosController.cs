using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using correios_integracao.Models;
using correios_integracao.Services.Interfaces;

namespace teste.Controllers
{
    [Route("/")]
    [ApiController]
    public class CorreiosController : ControllerBase
    {

        private readonly ICorreiosService correiosService;

        public CorreiosController(ICorreiosService correiosService)
        {
            this.correiosService = correiosService;
        }

        [HttpGet("endereco/cep/{cep}")]
        public async Task<IActionResult> ConsultaCEP(string cep)
        {
            var response = await correiosService.ConsultarCEP(cep);
            return Ok(response);
        }

        [HttpPost("calcular/prazo-preco")]

        public async Task<IActionResult> CalcularPrazoPreco([FromBody] CalculoModel calc)
        {
            try
            {
                return Ok(await correiosService.CalcularPrazo(calc.servico, calc.cepOrigem, calc.cepDestino,
                    calc.peso, calc.formato, calc.comprimento, calc.altura, calc.largura, calc.diametro,
                    calc.maoPropria, calc.valorDeclarado, calc.avisoRecebimento));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

    }
}
