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
                        Console.Clear();
                        Ecra.imprimirTabuleiro(partida.tab);
                      
                        Console.WriteLine();
                        Console.WriteLine();
                        
                        Console.Write("Origem: ");
                        Posicao origem = Ecra.lerPosicaoXadrez().toPosicao();

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();


                        Console.Clear();
                        Ecra.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.Write("Destino: ");
                        Posicao destino = Ecra.lerPosicaoXadrez().toPosicao();

                        partida.executaMovimento(origem, destino);

                    }
                    
                    
         
                  
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }


                Console.ReadKey();


        }
    }
}
