import java.util.Arrays;
import java.util.Scanner;
public class SortArrayOfStrings {

	public static void main(String[] args) {
		Scanner in = new Scanner(System.in);
		int n = in.nextInt();
		String[] words = new String[n];
		for (int i = 0; i < n; i++){
			words[i] = in.nextLine();
		}
		Arrays.sort(words);
		for(String word : words){
			System.out.println(word);
		}
		
	}

}
