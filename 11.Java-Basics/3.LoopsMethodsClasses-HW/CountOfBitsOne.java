import java.util.Scanner;
public class CountOfBitsOne {
	public static void main(String[] args){
		Scanner input = new Scanner(System.in);
		int number = input.nextInt();
		int count = 0;
		while (number > 0){
			if ((number & 1) == 1) {
				count++;
			}
			number >>>=1;
		}
		System.out.println(count);
	}
}
