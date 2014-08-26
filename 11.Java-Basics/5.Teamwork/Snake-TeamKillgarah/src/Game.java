import java.awt.Dimension;
import java.awt.Point;
import java.awt.Toolkit;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.event.KeyEvent;
import java.awt.event.KeyListener;
import java.util.Random;

import javax.swing.JFrame;
import javax.swing.Timer;



public class Game implements ActionListener, KeyListener {

	public static Game game;
	public JFrame jframe;
	public DrawGame drawGame;
	public Timer timer = new Timer(Globals.speed, this);
	public static final int NORTH = 0, SOUTH = 1, WEST = 2, EAST = 3;
	public int ticks = 0, direction, tailLength, time;
	public Random random;

	public Dimension dim;
	
	public static void main(String[] args) {
		game = new Game();
	}
	
	
	// initiate the JFrame

	public Game() {
		dim = Toolkit.getDefaultToolkit().getScreenSize();
		jframe = new JFrame("Snake");
		jframe.setVisible(true);
		jframe.setSize(Globals.gridSizeX * Globals.gameScale + 5, Globals.gridSizeY * Globals.gameScale + 30);
		jframe.setResizable(false);
		jframe.setLocation(dim.width / 2 - jframe.getWidth() / 2, dim.height
				/ 2 - jframe.getHeight() / 2);
		jframe.add(drawGame = new DrawGame());
		jframe.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		jframe.addKeyListener(this);
		startGame();
		
	}
	
	
	// initiate the variables for a new game

	public void startGame() {
		Globals.gameOver = false;
		Globals.gamePaused = false;
		time = 0;
		Globals.score = 0;
		tailLength = 1;
		ticks = 0;
		direction = SOUTH;
		Globals.snakeHead = new Point(0, -1);
		random = new Random();
		Globals.snakePoints.clear();
		Globals.apple = new Point(random.nextInt(Globals.gridSizeY-1), random.nextInt(Globals.gridSizeX-1));
		timer.start();
	}
	
	
	//movement and collision detection on every timer tick.

	public void actionPerformed(ActionEvent arg0) {
		drawGame.repaint();
		ticks++;
		if (ticks % 2 == 0 && Globals.snakeHead != null && !Globals.gameOver && !Globals.gamePaused) {
			time++;
			Globals.snakePoints.add(new Point(Globals.snakeHead.x, Globals.snakeHead.y));
			if (direction == NORTH)
				if (Globals.snakeHead.y - 1 >= 0 && checkForTail(Globals.snakeHead.x, Globals.snakeHead.y - 1))
					Globals.snakeHead = new Point(Globals.snakeHead.x, Globals.snakeHead.y - 1);
				else
					Globals.gameOver = true;
			if (direction == SOUTH)
				if (Globals.snakeHead.y + 1 < Globals.gridSizeY && checkForTail(Globals.snakeHead.x, Globals.snakeHead.y + 1))
					Globals.snakeHead = new Point(Globals.snakeHead.x, Globals.snakeHead.y + 1);
				else
					Globals.gameOver = true;
			if (direction == WEST)
				if (Globals.snakeHead.x - 1 >= 0 && checkForTail(Globals.snakeHead.x - 1, Globals.snakeHead.y))
					Globals.snakeHead = new Point(Globals.snakeHead.x - 1, Globals.snakeHead.y);
				else
					Globals.gameOver = true;
			if (direction == EAST)
				if (Globals.snakeHead.x + 1 < Globals.gridSizeX && checkForTail(Globals.snakeHead.x + 1, Globals.snakeHead.y))
					Globals.snakeHead = new Point(Globals.snakeHead.x + 1, Globals.snakeHead.y);
				else
					Globals.gameOver = true;
			if (Globals.snakePoints.size() > tailLength)
				Globals.snakePoints.remove(0);
			if (Globals.apple != null) {
				if (Globals.snakeHead.equals(Globals.apple)) {
					Globals.score += Globals.scoreApple;
					tailLength++;
					Globals.apple.setLocation(random.nextInt(Globals.gridSizeX-1), random.nextInt(Globals.gridSizeY-1));
				}
			}
			if (Globals.score % 10 == 0 && Globals.speed > 20) {
				Globals.speed -= 10;
			}
		}
	}
	
	// this method will check whether the head collides with any points
	// in the snakePoints array.
	public boolean checkForTail(int x, int y) {
		for (Point point : Globals.snakePoints) {
			if (point.equals(new Point(x, y))) {
				return false;
			}
		}
		return true;
	}
	
	
	// streaming the last key pressed for use when moving

	public void keyPressed(KeyEvent e) {
		int i = e.getKeyCode();
		if ((i == KeyEvent.VK_A || i == KeyEvent.VK_LEFT)  && direction != EAST)
			direction = WEST;
		if ((i == KeyEvent.VK_D || i == KeyEvent.VK_RIGHT) && direction != WEST)
			direction = EAST;
		if ((i == KeyEvent.VK_W || i == KeyEvent.VK_UP)  && direction != SOUTH)
			direction = NORTH;
		if ((i == KeyEvent.VK_S || i == KeyEvent.VK_DOWN) && direction != NORTH)
			direction = SOUTH;
		if (i == KeyEvent.VK_SPACE)
			if (Globals.gameOver)
				startGame();
			else
				Globals.gamePaused = !Globals.gamePaused;
	}

	
	// methods necessary for the KeyListener. Not used in our case
	
	public void keyReleased(KeyEvent e) {
	}

	public void keyTyped(KeyEvent e) {
	}

}