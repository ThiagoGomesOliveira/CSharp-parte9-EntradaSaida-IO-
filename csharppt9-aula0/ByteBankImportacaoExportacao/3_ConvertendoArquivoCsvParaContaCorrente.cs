using System;
using System.Text;
using System.IO;
using ByteBankImportacaoExportacao.Modelos;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Convertendo()
        {
            var arquivo = "contas.txt";
            using (var fluxoArquivo = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var conta = ConverterContaCorrente(linha);
                    string msg = $" Agência {conta.Agencia} Número {conta.Numero} Saldo {conta.Saldo} Titular {conta.Titular.Nome}";
                    Console.WriteLine(msg);
                }
                Console.ReadLine();

            }
        }


        public static ContaCorrente ConverterContaCorrente(string pTexto)
        {
            string[] campo = pTexto.Split(',');

            var agencia = campo[0];
            var numero = campo[1];
            var saldo = campo[2].Replace('.', ',');
            var titular = campo[3];

            int agenciaInt = int.Parse(agencia);
            int numeroInt = int.Parse(numero);
            double saldoDouble = double.Parse(saldo);
            Cliente cliente = new Cliente();
            cliente.Nome = titular;

            var conta = new ContaCorrente(agenciaInt, numeroInt);
            conta.Depositar(saldoDouble);
            conta.Titular = cliente;

            return conta;
        }

    }
}
