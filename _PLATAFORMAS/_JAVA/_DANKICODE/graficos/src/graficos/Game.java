package graficos;

import java.awt.BufferCapabilities;
import java.awt.Canvas;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Font;
import java.awt.Graphics;
import java.awt.Graphics2D;
import java.awt.image.BufferStrategy;
import java.awt.image.BufferedImage;
import java.io.BufferedReader;
import java.util.concurrent.SynchronousQueue;

import javax.swing.JFrame;

public class Game extends Canvas implements Runnable {

	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;
	private Thread thread;
	private boolean isRunning = true;
	public static JFrame frame;
	
	private final int WIDTH = 240;
	private final int HEIGHT = 160;
	// Escala 3 para dar um tom meio pixelado
	private final int SCALE = 3;
	
	private BufferedImage image;
	
	private Spritesheet sheet;
	
	// Para o caso de ser uma imagem est�tica
	// private BufferedImage player;
	// Para o caso de conter anima��es
	private BufferedImage[] player;
	// Para definir a quantidade de vezes que o frame � animado	
	private int frames = 0;
	private int maxFrames = 20;
	private int currentAnimation = 0;
	private int maxAnimation = 4;
	
	public Game()
	{
		sheet = new Spritesheet("/spritesheet.png");
		// Para o caso de ser uma imagem est�tica
		// player = sheet.getSprite(0, 0, 16, 16);
		// Para o caso de conter uma anima��o
		player = new BufferedImage[4];
		player[0] = sheet.getSprite(0, 0, 16, 16);
		player[1] = sheet.getSprite(16, 0, 16, 16);
		player[2] = sheet.getSprite(32, 0, 16, 16);
		player[3] = sheet.getSprite(48, 0, 16, 16);
		
		setPreferredSize(new Dimension(WIDTH*SCALE,HEIGHT*SCALE));
		initFrame();
		image = new BufferedImage(WIDTH, HEIGHT, BufferedImage.TYPE_INT_RGB);
	}
	
	public void initFrame() {
		frame = new JFrame("Game 01");
		frame.add(this);
		frame.setResizable(false);
		frame.pack();
		frame.setLocationRelativeTo(null);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.setVisible(true);
	}
	
	public synchronized void start() {
		thread = new Thread(this);
		isRunning = true;
		thread.start();
	}
	
	public synchronized void stop() {

		isRunning = false;
		try {
			thread.join();
		} catch (InterruptedException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public static void main(String args[]) {
		
		Game game = new Game();
		game.start();
		
	}
	
	// Fun��o respons�vel pelo update (atualiza��o do game)
	public void tick() {
		frames++;
		if(frames > maxFrames) {
			frames = 0;
			currentAnimation++;
			if(currentAnimation >= maxAnimation) {
				currentAnimation = 0;
			}
		}
	}
	
	// M�todo respons�vel pelos gr�ficos
	
	// BufferStrategy � uma classe repons�vel para
	// colocar uma s�rie de buffers para renderiza��o.
	public void render() {
		BufferStrategy bs = this.getBufferStrategy();
		
		if(bs == null) {
			this.createBufferStrategy(3);
			return;
		}
		
		// Inicializando a tela
		Graphics g = image.getGraphics();
		//g.setColor(new Color(255,0,0));
		//g.setColor(new Color(0,0,0));
		g.setColor(new Color(0,0,255));
		g.fillRect(0, 0, WIDTH, HEIGHT);
		
		// Renderizando um c�culo
		//g.setColor(Color.CYAN);
		//g.fillRect(20, 20, 80, 80);
		
		// Renderiznado uma String
		//g.setFont(new Font("Arial",Font.BOLD,20));
		//g.setColor(Color.WHITE);
		//g.drawString("Hello World", 19, 19);
		
		/* Renderiza��o do Jogo */
		
		/****/
		
		// Para rotacionar o spritesheet.
		/* Lembrando que este spritesheet tem
		 * 16 x 16 pixels. Ent�o no m�todo rotate
		 * da classe Graphics2D o primeiro par�metro
		 * (que define a rota��o) deve ser convertido
		 * em radianos. Os 2 �ltimos par�metros devem
		 * conter as coordenadas que informam onde est�
		 * o spritesheet e preferencialmente somar a estes
		 * valores a metade do valor do tamanho horizontal
		 * e vertical do spritesheet. No caso j� � o tamanho
		 * � 16 x 16, ent�o deve ser somado 8 a cada uma das
		 * coordenadas porque nesse caso ele ir� rotacionar
		 * o spritesheet exatamente em seu centro.
		 * 
		 */
		Graphics2D g2 = (Graphics2D) g;
		//g2.rotate(Math.toRadians(45), 90 + 8, 90 + 8);
		
		// Desenhando o player (jogador)
		g2.drawImage(player[currentAnimation], 90, 90, null);
		//g.drawImage(player, x, 40, null);
		//g.drawImage(player, 20, 80, null);
		//g.drawImage(player, x, 100, null);
		
		// Para limpar o lixo do buffer na imagem
		g.dispose();		
		
		g = bs.getDrawGraphics();
		g.drawImage(image, 0, 0, WIDTH*SCALE, HEIGHT*SCALE, null);
		
		bs.show();
	}
	
	@Override
	public void run() {

		// Pega o �ltimo momento em nanotime 
		// porque a precis�o aumenta.
		long lastTime = System.nanoTime();
		
		// Uma constante que carrega o n�mero de frames
		double amountOfTicks = 60.0;
		
		// Esse abaixo � o momento certo que deve
		// ser feito o update do game
		// O valor de 100 milh�es abaixo � o mesmo
		// que 1 segundo em nano segundos.
		double ns = 1000000000 / amountOfTicks;
		
		double delta = 0;
		
		int frames = 0;
		double timer = System.currentTimeMillis();
		
		while(isRunning) {
			
			long now = System.nanoTime();
			delta+= (now - lastTime) / ns;
			
			lastTime = now;
			
			if(delta >= 1) {
				// Sempre se deve atualizar antes de renderizar
				tick();
				render();
				frames++;
				delta--;
			}
			
			// Para confer�ncia dos FPS
			if(System.currentTimeMillis() - timer >= 1000) {
				System.out.println("FPS: " + frames);
				frames = 0;
				timer += 1000;
			}
			
		}
		
		stop();
		
	}

}
