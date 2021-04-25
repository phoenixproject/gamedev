using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ1
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Baralho deck = new Baralho(4);
            //deck.Imprimir();
            Console.WriteLine();
            deck.Embaralhar();
           // deck.Imprimir();

            Jogador j1 = new Jogador("Samus");

            Jogador[] jogadores = new Jogador[2];
            jogadores[0] = new Dealer();
            jogadores[0].QuerCarta();


            while (j1.QuerCarta())
            {
                j1.ComprarCarta(deck.DarCarta());
                j1.Imprimir();
            }

            Console.ReadKey();
        }
    }
}
