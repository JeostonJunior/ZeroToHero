using System;

namespace AluguelCarros.Models
{
    public class ServicoLocacao
    {
        public double ValorHora { get; set; }
        public double ValorDia { get; set; }

        private Taxa _taxa = new Taxa();
        public ServicoLocacao (double valorHora, double valorDia)
        {
            ValorHora = valorHora;
            ValorDia = valorDia;
        }
        public void ProcessaLocacao (AluguelCarro aluguelCarro)
        {
            TimeSpan duration = aluguelCarro.DiaDevolução.Subtract(aluguelCarro.DiaDevolução);

            double pagamento = 0.00;
            if (duration.TotalHours <= 12)
            {
                pagamento = ValorHora * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                pagamento = ValorDia * Math.Ceiling(duration.TotalDays);
            }
            double taxa = _taxa.TaxaBrasil(pagamento);

            aluguelCarro.Fatura = new Fatura(pagamento, taxa);
        }
    }
}
