import java.util.Scanner;
public class FormattingNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int a = input.nextInt();
		double b = input.nextDouble();
		double c = input.nextDouble();
		String aBinary = String.format("%10s", Integer.toBinaryString(a)).replace(' ', '0');
		System.out.printf("|%1$-10X|%2$s|%3$10.2f|%4$-10.3f|",a,aBinary,b,c);

	}

}
