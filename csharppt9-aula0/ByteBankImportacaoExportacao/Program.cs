using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ByteBankImportacaoExportacao
{
    class Program
    {
        static void Main(string[] args)
        {

            var arquivo = "contas.txt";
            var fluxoArquivo = new FileStream(arquivo, FileMode.Open);
            var buffer = new byte[1024];
            fluxoArquivo.Read(buffer, 0, 1024);
            var aQuantidadeByte = -1;

            while (aQuantidadeByte != 0)
            {
                aQuantidadeByte = fluxoArquivo.Read(buffer, 0, 1024);
                EscreverBuffer(buffer);
            }

            Console.ReadLine();
        }

        public static void EscreverBuffer(byte[] pBuffer)
        {
            var enconding = new UTF8Encoding();
            Console.Write(enconding.GetString(pBuffer));
        }
    }
}
