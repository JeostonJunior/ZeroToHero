using System.Globalization;

namespace ServicoAluguelCarros.Models
{
    public class Locacao
    {
        public double PagamentoBasico { get; set; }
        public double Imposto { get; set; }

        public Locacao (double pagamentoBasico, double imposto)
        {
            PagamentoBasico = pagamentoBasico;
            Imposto = imposto;
        }

        public double PagamentoTotal ()
        {
            return PagamentoBasico + Imposto;
        }
        public override string ToString ()
        {
            return $"PAGAMENTO: {PagamentoTotal().ToString("F2", CultureInfo.InvariantCulture)}\n{Imposto.ToString("F2", CultureInfo.InvariantCulture)}\n{PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
