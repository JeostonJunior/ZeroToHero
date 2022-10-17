using System;

namespace AluguelCarros.Models
{
    public class AluguelCarro
    {
        public DateTime DiaLocacao { get; set; }
        public DateTime DiaDevolução { get; set; }
        public Veiculo Veiculo { get; set; }
        public Fatura Fatura { get; set; }

        public AluguelCarro (DateTime diaLocacao, DateTime diaDevolução, Veiculo veiculo)
        {
            DiaLocacao = diaLocacao;
            DiaDevolução = diaDevolução;
            Veiculo = veiculo;
            Fatura = null;
        }
    }
}
