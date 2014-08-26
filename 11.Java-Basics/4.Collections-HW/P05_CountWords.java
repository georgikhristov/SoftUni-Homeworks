import java.util.Scanner;


public class P05_CountWords {

	public static void main(String[] args) {
		try(Scanner input = new Scanner(System.in);){
			String[] words = input.nextLine().split("\\W+");
			System.out.println(words.length);
		}
	}
}
