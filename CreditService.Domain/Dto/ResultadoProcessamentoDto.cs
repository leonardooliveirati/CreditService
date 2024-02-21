namespace CreditService.Domain.Dto
{
    public class ResultadoProcessamentoDto
    {
        public string Status { get; set; }
        public decimal ValorTotalComJuros { get; set; }
        public decimal ValorJuros { get; set; }
        public string Mensagem { get; set; }
    }
}
