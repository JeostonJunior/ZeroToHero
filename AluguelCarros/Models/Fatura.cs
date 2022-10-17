using System.Globalization;

namespace AluguelCarros.Models
{
    public class Fatura
    {
        public double PrecoLocacao { get; set; }
        public double Taxa { get; set; }
        public Fatura (double precoLocacao, double taxa)
        {
            PrecoLocacao = precoLocacao;
            Taxa = taxa;
        }
        public double ValorTotal ()
        {
            return PrecoLocacao + Taxa;
        }
        public override string ToString ()
        {
            return $"Basic Payment: {PrecoLocacao.ToString("F2", CultureInfo.InvariantCulture)}\nTax: {Taxa.ToString("F2", CultureInfo.InvariantCulture)}\nTotal payment: {ValorTotal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
