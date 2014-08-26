import java.util.Scanner;
public class SmallestOfThreeNums {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		double first = input.nextDouble();
		double second = input.nextDouble();
		double third = input.nextDouble();
		double min = first;
		if (min > second){
			min = second;
		}
		if (min > third){
			min = third;
		}
		System.out.println(min);
	}
}
