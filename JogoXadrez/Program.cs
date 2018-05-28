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
                    Ecra.imprimirTabuleiro(partida.tab);
                  
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }


                Console.ReadKey();


        }
    }
}
