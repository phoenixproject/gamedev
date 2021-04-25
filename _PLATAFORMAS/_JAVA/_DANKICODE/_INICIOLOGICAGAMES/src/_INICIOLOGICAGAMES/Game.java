package _INICIOLOGICAGAMES;

import java.util.ArrayList;

public class Game implements Runnable {
	
	private boolean isRunning;
	private Thread thread;

	private ArrayList<Entidade> entidades = new ArrayList<>();
	
	public Game() {
		entidades.add(new Entidade());
		entidades.add(new Entidade());
		entidades.add(new Entidade());
		entidades.add(new Entidade());
		for(int i = 0; i < entidades.size(); i++) {
			Entidade e = entidades.get(0);
		}
	}
	
	public static void main(String[] args) {
		
		Game game = new Game();
		
		// Para iniciar o jogo.
		game.start();
	}
	
	public synchronized void start() {
		
		isRunning = true;
		
		// O this diz que é esta própria classe que entrará numa thread
		thread = new Thread(this);
		thread.start();
	}
	
	// tick pode ser uma volta no loop ou atualizar
	public void tick() {
		System.out.println("Tick");
	}
	
	// Renderizar o jogo
	public void render() {
		System.out.println("Render");		
	}

	@Override
	public void run() {

		while(isRunning) {
			
			tick();
			render();
			
			// Forma 1 de executar uma Thread em 60 vezes por segundo.
			/*try {
				Thread.sleep(1000/60);
			} catch (InterruptedException e) {				
				e.printStackTrace();
			}*/
			
			
		}
		
	}
	
}
