import java.util.Scanner;


public class P07_CountSubstringOccurrences {

	public static void main(String[] args) {
		try(Scanner input = new Scanner(System.in);){
			String text = input.nextLine().toLowerCase();
			String word = input.nextLine().toLowerCase();
			int count = 0;
			for (int i = 0; i < text.length() - word.length() + 1; i++) {
				String current = text.substring(i, i + word.length());
				if (current.equals(word)) {
					count++;
				}
			}
			System.out.println(count);
		}
	}

}
