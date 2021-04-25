package pong;

import java.awt.Canvas;
import java.awt.Dimension;

import javax.swing.JFrame;

public class Game extends Canvas implements Runnable {

	private static final long serialVersionUID = 1L;
	
	private static int WIDTH = 240;
	private static int HEIGHT = 120;
	private static int SCALE = 3;

	public Game() {
		this.setPreferredSize(new Dimension(WIDTH*SCALE,HEIGHT*SCALE));
	}
	
	public static void main(String[] args) {
		
		Game game = new Game();
		
		// Criando uma janela para a aplica��o
		// Informando o nome da janela
		JFrame frame = new JFrame("Pong");
		
		// Nesta op��o fica habilitado que o usu�rio n�o 
		// pode fechar a janela		
		frame.setResizable(false);
		
		// Para quando usu�rio fechar a janela
		// o jogo n�o continuar rodando em background
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		
		// Aqui o frame � criado esperando o componente.
		// O componente no caso � a pr�pria inst�ncia do game.
		frame.add(game);
		frame.pack();
		
		// setLocation com o par�metro null sempre lan�a
		// a janela no centro da tela.
		frame.setLocationRelativeTo(null);
		
		// Para que a janela seja exibida
		frame.setVisible(true);
		
		
	}
	
	@Override
	public void run() {
		// TODO Auto-generated method stub
		
	}

}
