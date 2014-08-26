import java.util.Scanner;
import java.util.concurrent.CountDownLatch;
public class PointsInFigure {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		double x = input.nextDouble();
		double y = input.nextDouble();
		boolean inBigRectangle = (x >= 12.5) && (x <= 22.5) 
				&& (y >= 6) && (y <= 13.5);
		boolean outSmallRectangle = !((x > 17.5) && (x < 20) 
				&& (y > 8.5) && (y < 13.5));
		String output;
		if (inBigRectangle && outSmallRectangle) {
			output = "Inside";
		} else {
			output = "Outside";
		}
		System.out.println(output);
	}

}
