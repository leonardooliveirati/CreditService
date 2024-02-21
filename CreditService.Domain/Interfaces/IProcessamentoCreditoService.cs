using CreditService.Domain.Dto;

namespace CreditService.Domain.Interfaces
{
    public interface IProcessamentoCreditoService
    {
        Task<ResultadoProcessamentoDto> ProcessarCredito(CreditoDto credito);
    }
}
