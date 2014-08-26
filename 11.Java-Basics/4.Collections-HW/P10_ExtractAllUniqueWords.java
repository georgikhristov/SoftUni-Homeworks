import java.util.Scanner;
import java.util.TreeSet;


public class P10_ExtractAllUniqueWords {

	public static void main(String[] args) {
		try(Scanner input = new Scanner(System.in);){
			String[] words = input.nextLine().toLowerCase().split("\\W+");
			TreeSet<String> unique = new TreeSet<>();
			for (String word : words) {
				unique.add(word);
			}
			for (String word : unique) {
				System.out.print(word + " ");
			}
		}

	}

}
