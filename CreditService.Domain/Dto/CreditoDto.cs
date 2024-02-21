using CreditService.Domain.Enums;

namespace CreditService.Domain.Dto
{
    public class CreditoDto
    {
        public decimal Valor { get; set; }
        public TipoCredito Tipo { get; set; }
        public int QuantidadeParcelas { get; set; }
        public DateTime DataPrimeiroVencimento { get; set; }
    }
}
