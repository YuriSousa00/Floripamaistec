class Program
{

    public static void Main(string[] args)
    {
        FileInfo arquivo = null;
        try
        {

            Console.Write("Digite o nome do arquivo que você vai criar: ");
            string nomeArquivo = Console.ReadLine();

            arquivo = new FileInfo(nomeArquivo);

            using (StreamWriter gravadorFluxo = File.AppendText(nomeArquivo))
            {
                gravadorFluxo.WriteLine("Texto de dentro do arquivo.");
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }

        finally
        {
            Console.WriteLine($"Encerrando programa...\n");
           // arquivo = null;
          //  Console.Clear();
        }
    }
}

