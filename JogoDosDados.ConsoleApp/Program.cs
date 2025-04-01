using System.Runtime.CompilerServices;

namespace JogoDosDados.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int limiteLinhaChegado = 30;

            while(true)
            {            
                int posicaoUsuario = 0;

                bool jogoEstaEmAndamento = true;

                while(jogoEstaEmAndamento)
                {
                    ExibirCabecalho();

                    int resultado = LancarDado();

                    ExibirResultadoSorteio(resultado);

                    posicaoUsuario += resultado;

                    Console.WriteLine($"O Jogador está na posíção: {posicaoUsuario} do {limiteLinhaChegado}");

                    if (posicaoUsuario >= limiteLinhaChegado)
                    {
                        Console.WriteLine("Parabéns, você alcançou a linha de chegada!");

                        jogoEstaEmAndamento = false;
                    }
                    else
                        Console.WriteLine($"O jogador está na posição: {posicaoUsuario} de {limiteLinhaChegado}");

                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Pressione ENTER para Continuar....");
                    Console.ReadLine();
                }                

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
            Console.WriteLine("----------------------------------------");
            Console.Write("Deseja continuar? (S/N): ");
            string opcaoContinuar = Console.ReadLine()!.ToUpper();

            return opcaoContinuar;
        }
    }
}
