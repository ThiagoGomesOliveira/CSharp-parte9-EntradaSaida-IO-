using System;
using System.Text;
using System.IO;
using ByteBankImportacaoExportacao.Modelos;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main(string[] args)
        {
            CriarArquivoStream();
            Console.WriteLine("Finalizado com sucesso ...");
            Console.Read();
        }

        public static void CriarArquivo()
        {
            var caminhoArquivo = "ContasExportadas.csv";

            using (var FluxoArquivo = new FileStream(caminhoArquivo,FileMode.Create))
            {
                string contaExp = "666,666,1234.2,Thiago Gomes Oliveira";
                var enconding = Encoding.UTF8;
                var bytes = enconding.GetBytes(contaExp);
                FluxoArquivo.Write(bytes, 0, bytes.Length);
            }
        }

        public static void CriarArquivoStream()
        {
            var caminhoArquivo = "ContasExportadasStream";

            using (var fluxoArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var texto = new StreamWriter(fluxoArquivo, Encoding.UTF8))
            {
                texto.Write("666,667,2.000,Juliana Leoni");
            }
        }
    }
}
