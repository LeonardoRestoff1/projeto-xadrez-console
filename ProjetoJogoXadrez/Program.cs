using System;
using tabuleiro;
using xadrez;

namespace ProjetoJogoXadrez
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try { 

                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Console.Clear();
                    Tela.imprimirTabuleiro(partida.tab);

                    Console.WriteLine();
                    Console.Write("Origem: ");
                    Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                    Console.Write("Destino: ");
                    Posicao destinho = Tela.lerPosicaoXadrez().toPosicao();

                    partida.executaMovimento(origem, destinho);
                }

                Tela.imprimirTabuleiro(partida.tab);

            }
            catch (TabuleiroException ex)
            {
                Console.WriteLine(ex.Message);
            }

        Console.WriteLine();
      
        }
    }
}
