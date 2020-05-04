using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BJ1
{
    class BlackJack
    {
        private Baralho deck;
        private List<Jogador> jogadores;

        public BlackJack()
        {
            //criar baralho
            deck = new Baralho(4);
            deck.Embaralhar();
            //criar lista jogadores
            jogadores = new List<Jogador>();
        }

        public void Jogar()
        {
            //criar jogadores
            //criar dealer
            //distribuir cartas 
            //virar a segunda do dealer
            //mostra estado

            //loop do jogo
            //para cada jogador
            //enquanto quiser carta compra até parar ou estourar
            //quando chegar a vez do dealer, virar a carta

            //saida do loop
            //determinar quem ganhou e quem perdeu
        }

        private void CriarJogadores()
        {

        }

        private void MostrarJogadores()
        {

        }

    }
}
