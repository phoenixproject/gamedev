package graficos;

import java.awt.BufferCapabilities;
import java.awt.Canvas;
import java.awt.Color;
import java.awt.Dimension;
import java.awt.Graphics;
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
	private final int WIDTH = 160;
	private final int HEIGHT = 120;
	private final int SCALE = 4;
	
	private BufferedImage image;
	
	public Game()
	{
		this.setPreferredSize(new Dimension(WIDTH*SCALE,HEIGHT*SCALE));
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
	
	// Função responsável pelo update (atualização do game)
	public void tick() {
		
	}
	
	// Método responsável pelos gráficos
	
	// BufferStrategy é uma classe reponsável para
	// colocar uma série de buffers para renderização.
	public void render() {
		BufferStrategy bs = this.getBufferStrategy();
		
		if(bs == null) {
			this.createBufferStrategy(3);
			return;
		}
		
		// Inicializando a tela
		Graphics g = image.getGraphics();
		g.setColor(new Color(255,0,0));
		g.fillRect(0, 0, 160, 120);
		
		g.setColor(Color.CYAN);
		g.fillRect(20, 20, 80, 80);
		
		g = bs.getDrawGraphics();
		g.drawImage(image, 0, 0, WIDTH*SCALE, HEIGHT*SCALE, null);
		
		bs.show();
	}
	
	@Override
	public void run() {

		// Pega o último momento em nanotime 
		// porque a precisão aumenta.
		long lastTime = System.nanoTime();
		
		// Uma constante que carrega o número de frames
		double amountOfTicks = 60.0;
		
		// Esse abaixo é o momento certo que deve
		// ser feito o update do game
		// O valor de 100 milhões abaixo é o mesmo
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
			
			// Para conferência dos FPS
			if(System.currentTimeMillis() - timer >= 1000) {
				System.out.println("FPS: " + frames);
				frames = 0;
				timer += 1000;
			}
			
		}
		
		stop();
		
	}

}
