using System;
using System.Text;
using System.IO;
namespace ByteBankImportacaoExportacao
{
   partial class Program
    {
       public static void ListandoFileStream()
        {
            var arquivo = "contas.txt";
            using (var fluxoArquivo = new FileStream(arquivo, FileMode.Open))
            {
                var buffer = new byte[1024];
                fluxoArquivo.Read(buffer, 0, 1024);
                var aQuantidadeByte = -1;

                while (aQuantidadeByte != 0)
                {
                    aQuantidadeByte = fluxoArquivo.Read(buffer, 0, 1024);
                    EscreverBuffer(buffer, aQuantidadeByte);
                }
                fluxoArquivo.Close();
                Console.ReadLine();
            }


        }

        private static  void EscreverBuffer(byte[] pBuffer, int pBytesLidos)
        {
            var enconding = new UTF8Encoding();
            Console.Write(enconding.GetString(pBuffer, 0, pBytesLidos));

        }
    }
}
