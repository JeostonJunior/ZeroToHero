using ServicoAluguelCarros.Models;
using ServicoAluguelCarros.Services;
using System;
using System.Globalization;

namespace ServicoAluguelCarros
{
    internal class Program
    {
        static void Main ()
        {
            Console.WriteLine("Serviço de locação de Veiculos, Entre com os valores solicitados");
            Console.Write("Modelo do Carro: ");
            string modelo = Console.ReadLine();
            Console.Write("Data de Locação: ");
            DateTime dataLocacao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data de Devolução: ");
            DateTime dataDevolucao = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Preço por hora: ");
            double precoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Preço por dia: ");
            double precoDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            LocacaoVeiculo locacaoVeiculo = new LocacaoVeiculo(new Veiculo(modelo), dataLocacao, dataDevolucao);
            ServicoLocacao servicoLocacao = new ServicoLocacao(precoHora, precoDia, new ServiceBrasilImposto());

            servicoLocacao.ProcessoLocacao(locacaoVeiculo);

            Console.WriteLine("CONTRATO:");
            Console.WriteLine(locacaoVeiculo.Locacao);
        }
    }
}
