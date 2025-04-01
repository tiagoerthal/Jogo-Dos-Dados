namespace JogoDosDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {            
                ExibirCabecalho();
              
                int resultado =LancarDado();
             
                ExibirResultadoSorteio(resultado);

                string opcaoContinuar = ExbirMenuContinuar();

                if (opcaoContinuar != "S")
                    break;             
            }           
        }

        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Jogo Dos Dados");
            Console.WriteLine("----------------------------------------");

            Console.Write("Pressione ENTER para Lançar o dado...");
            Console.ReadLine();
        }

        static int LancarDado()
        {
            Random geradorDeNumeros = new Random();

            int resultado = geradorDeNumeros.Next(1, 7);

            return resultado;
        }

        static void ExibirResultadoSorteio(int resultado)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine($"O Valor sorteado foi: {resultado}");
            Console.WriteLine("----------------------------------------");
        }

        static string ExbirMenuContinuar()
        {
            Console.Write("Deseja continuar? (S/N): ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            return opcaoContinuar;
        }
    }
}
