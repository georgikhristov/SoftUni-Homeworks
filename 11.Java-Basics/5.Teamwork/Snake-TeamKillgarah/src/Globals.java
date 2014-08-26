import java.awt.Point;
import java.util.ArrayList;



/* This class holds all the global variables and 
 * constants so that they can be referenced or
 * modified by all other classes/methods.
 
 */


public class Globals {
	
	// constants - these are not changed during execution
	
	public static final int gridSizeX = 40;	// the width of the game grid
	public static final int gridSizeY = 40;	// the height of the game grid
	public static final int scoreApple = 1;	// how many points you get by eating an apple
	public static final int gameScale = 10; // the scale of each point, in pixels.
	
	
	//variables - changed during execution
	
	public static int speed = 60;											// sets the game speed, milliseconds per frame, decreased every 10 points until it reaches 20
	public static Point snakeHead = new Point();							// keeps X Y values of head snake
	public static ArrayList<Point> snakePoints = new ArrayList<Point>();	// keeps array of all other snake parts
	public static Point apple = new Point();								// keeps X Y values of the apple
	public static int score = 0;											// variable to keep the score; nullified on new game
	public static boolean gameOver = false; 								// shows if the game should end
	public static boolean gamePaused = false;								// keeps whether game is paused
	
	
	
}
