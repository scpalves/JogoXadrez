using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TabuleiroData;
using XadrezBusiness;

namespace JogoXadrez
{
    class Program
    {
        static void Main(string[] args)
            {

               
                try
                {
                    PartidaXadrez partida = new PartidaXadrez();

                    while (!partida.terminada)
                    {
                        try
                        {



                            Console.Clear();
                            Ecra.imprimirPartida(partida);

                            //Ecra.imprimirTabuleiro(partida.tab);

                            //Console.WriteLine();
                            //Console.WriteLine("Turno: " + partida.turno);
                            //Console.WriteLine("Aguardando jogada: " + partida.jogadorAtual);

                            Console.WriteLine();
                            Console.WriteLine();

                            Console.Write("Origem: ");
                            Posicao origem = Ecra.lerPosicaoXadrez().toPosicao();

                            partida.validarPosicaoOrigem(origem);

                            bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();


                            Console.Clear();
                            Ecra.imprimirTabuleiro(partida.tab, posicoesPossiveis);


                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("Destino: ");
                            Posicao destino = Ecra.lerPosicaoXadrez().toPosicao();
                            partida.validarPosicaoDestino(origem, destino);

                            partida.realizaJogada(origem, destino);

                        }
                        catch (TabuleiroException e)
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadLine();
                        }
                    }


                    Console.Clear();
                    Ecra.imprimirPartida(partida);
         
                  
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }


                Console.ReadKey();


        }
    }
}
