import java.util.Scanner;


public class P06_CountSpecifiedWord {

	public static void main(String[] args) {
		try(Scanner input = new Scanner(System.in);){
			String[] words = input.nextLine().toLowerCase().split("\\W+");
			String wordCounted = input.nextLine().toLowerCase();
			int count = 0;
			for (String word : words) {
				if(word.equals(wordCounted)){
					count++;
				}
			}
			System.out.println(count);
		}

	}

}
