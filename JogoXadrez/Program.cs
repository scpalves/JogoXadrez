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

                PosicaoXadrez pos = new PosicaoXadrez('a', 1);

                Console.WriteLine(pos);

                Console.WriteLine(pos.toPosicao());

            //    try 
            //{
            //    Tabuleiro tab = new Tabuleiro(8, 8);

            //    tab.colocarPeca(new Torre(tab, Cor.Azul), new Posicao(0, 0));
            //    tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
            //    tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(2, 4));
            //    tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

            //    Ecra.imprimirTabuleiro(tab);
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e.Message);
            //}


                Console.ReadKey();


        }
    }
}
