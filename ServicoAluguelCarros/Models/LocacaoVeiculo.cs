using System;

namespace ServicoAluguelCarros.Models
{
    public class LocacaoVeiculo
    {
        public Veiculo Veiculo { get; set; }
        public DateTime DiaLocacao { get; set; }
        public DateTime DiaDevolucao { get; set; }
        public Locacao Locacao { get; set; }

        public LocacaoVeiculo (Veiculo veiculo, DateTime diaLocacao, DateTime diaDevolucao)
        {
            Veiculo = veiculo;
            DiaLocacao = diaLocacao;
            DiaDevolucao = diaDevolucao;
            Locacao = null;
        }
    }
}
