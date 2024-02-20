using CreditService.Domain.Dto;
using CreditService.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CreditService.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditServiceController : ControllerBase
    {
        private readonly IProcessamentoCreditoService _processamentoCréditoService;

        public CreditServiceController(IProcessamentoCreditoService processamentoCreditoService)
        {
            _processamentoCréditoService = processamentoCreditoService;
        }

        [HttpPost()]
        public async Task<IActionResult> PostAsync([FromBody] CreditoDto credit)
        {
            try
            {
                if (credit == null)
                    return NotFound();

                var resultado = await _processamentoCréditoService.ProcessarCredito(credit);
                return Ok(resultado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
