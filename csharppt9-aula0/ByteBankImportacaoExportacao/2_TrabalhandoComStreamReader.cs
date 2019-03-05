using System;
using System.Text;
using System.IO;
namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void ListandoStreamReader()
        {
            var arquivo = "contas.txt";
            using (var fluxoArquivo = new FileStream(arquivo, FileMode.Open))
            using (var leitor = new StreamReader(fluxoArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    Console.WriteLine(linha);
                }
                Console.ReadLine();
            }
        }
    }
}
