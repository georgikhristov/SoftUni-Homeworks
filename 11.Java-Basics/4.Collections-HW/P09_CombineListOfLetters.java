import java.util.ArrayList;
import java.util.Scanner;


public class P09_CombineListOfLetters {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		ArrayList<Character>list = new ArrayList<>();
		for (char letter : input.nextLine().toCharArray()) {
			if (letter != ' ') {
				list.add(letter);
			}
		}
		for (char letter : input.nextLine().toCharArray()) {
			if (!list.contains(letter) && letter != ' ') {
				list.add(letter);
			}
		}
		for (char letter : list) {
			System.out.print(letter + " ");
		}
		

	}

}
