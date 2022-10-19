using ServicoAluguelCarros.Models;
using System;

namespace ServicoAluguelCarros.Services
{
    public class ServicoLocacao
    {
        public double ValorHora { get; set; }
        public double ValorDia { get; set; }

        private IServiceImposto _serviceImposto;

        public ServicoLocacao (double valorHora, double valorDia, IServiceImposto serviceImposto)
        {
            ValorHora = valorHora;
            ValorDia = valorDia;
            _serviceImposto = serviceImposto;
        }

        public void ProcessoLocacao (LocacaoVeiculo locacao)
        {
            TimeSpan duracao = locacao.DiaDevolucao.Subtract(locacao.DiaLocacao);

            double pagamentoBasico = 0.00;
            if (duracao.TotalHours <= 12.00)
            {
                pagamentoBasico = ValorHora * Math.Ceiling(duracao.TotalHours);
            }
            else
            {
                pagamentoBasico = ValorDia * Math.Ceiling(duracao.TotalDays);
            }

            double imposto = _serviceImposto.Imposto(pagamentoBasico);

            locacao.Locacao = new Locacao(pagamentoBasico, imposto);
        }

    }
}
