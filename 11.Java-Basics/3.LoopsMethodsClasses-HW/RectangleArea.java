import java.util.Scanner;
public class RectangleArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		double sideA = input.nextDouble();
		double sideB = input.nextDouble();
		double area = sideA*sideB;
		System.out.println(area);

	}

}
