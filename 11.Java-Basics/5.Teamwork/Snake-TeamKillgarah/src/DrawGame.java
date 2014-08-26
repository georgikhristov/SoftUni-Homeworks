import java.awt.Color;
import java.awt.Graphics;
import java.awt.Point;

import javax.swing.JPanel;

//warnings are suppressed 
@SuppressWarnings("serial")


public class DrawGame extends JPanel {

	

	@Override
	protected void paintComponent(Graphics g) {
		
		super.paintComponent(g);
		g.setColor(Color.BLACK);
		g.fillRect(0, 0, Globals.gridSizeX * Globals.gameScale + 5, Globals.gridSizeY * Globals.gameScale + 30);
		Game snake = Game.game;
		g.setColor(Color.BLUE);
		for (Point point : Globals.snakePoints) {
			g.fillRect(point.x * Globals.gameScale, point.y * Globals.gameScale, Globals.gameScale, Globals.gameScale);
		}
		g.fillRect(Globals.snakeHead.x * Globals.gameScale, Globals.snakeHead.y * Globals.gameScale, Globals.gameScale, Globals.gameScale);
		g.setColor(Color.RED);
		g.fillRect(Globals.apple.x * Globals.gameScale, Globals.apple.y * Globals.gameScale, Globals.gameScale, Globals.gameScale);
		String string = "Score: " + Globals.score + ", Length: "
				+ snake.tailLength;
		g.setColor(Color.white);
		g.drawString(string, (int) (getWidth() / 2 - string.length() * 2.5f), 10);
		
		string = "Game Over!";
		
		if (Globals.gameOver)
			g.drawString(string,
					(int) (getWidth() / 2 - string.length() * 2.5f),
					(int) snake.dim.getHeight() / 4);
		string = "Paused!";
		
		if (Globals.gamePaused && !Globals.gameOver)
			g.drawString(string,
					(int) (getWidth() / 2 - string.length() * 2.5f),
					(int) snake.dim.getHeight() / 4);
	}
}