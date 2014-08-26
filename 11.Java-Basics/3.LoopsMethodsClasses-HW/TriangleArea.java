import java.util.Scanner;
public class TriangleArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		double ax = input.nextDouble();
		double ay = input.nextDouble();
		double bx = input.nextDouble();
		double by = input.nextDouble();
		double cx = input.nextDouble();
		double cy = input.nextDouble();
		double area;
		
		//check if the points are on the same line
		if ((ay-by)/(ax-bx) == (ay-cy)/(ax-cx)) {
			area = 0;
		} 
		//else -> they form a triangle
		else {
			area = Math.abs((ax*(by-cy) + bx*(cy-ay) + cx*(ay-by)) / 2);
		}
		int roundedArea = (int)Math.round(area);
		System.out.println(roundedArea);
	}

}
