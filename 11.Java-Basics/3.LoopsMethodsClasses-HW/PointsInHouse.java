import java.util.Scanner;


public class PointsInHouse {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		double x = input.nextDouble();
		double y = input.nextDouble();
		
		boolean inBigRectangle = (x >= 12.5) && (x <= 22.5) 
				&& (y >= 8.5) && (y <= 13.5);
		
		boolean outSmallRectangle = !((x > 17.5) && (x < 20) 
				&& (y > 8.5) && (y < 13.5));
		
		//first side of triangle
		double firstPosition = (17.5-12.5)*(y-8.5) - (3.5-8.5)*(x-12.5);
		boolean firstLine = firstPosition > 0;
		
		//second side of triangle
		double secondPosition = (17.5-22.5)*(y-8.5) - (3.5-8.5)*(x-22.5);
		boolean secondLine = secondPosition < 0;
		
		//third side of triangle
		double thirdPosition = (22.5-12.5)*(y-8.5) - (8.5-8.5)*(x-12.5);
		boolean thirdLine = thirdPosition < 0;
		
		boolean inTriangle = firstLine && secondLine && thirdLine;
		
		if ((inBigRectangle && outSmallRectangle) || inTriangle) {
			System.out.println("Inside");
		} else {
			System.out.println("Outside");
		}
	}

}
