import java.util.Map;
import java.util.Scanner;
import java.util.HashMap;


public class P12_CardFrequencies {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] words = input.nextLine().split("[♠♥♦♣]+[ ]*");
		HashMap<String, Integer> unique = new HashMap<>();
		for (String word : words) {
			if (unique.containsKey(word)) {
				unique.replace(word, unique.get(word) + 1);
			} else {
				unique.put(word, 1);
			}	
		}
		for (Map.Entry<String, Integer> entry : unique.entrySet()) {
			double frequency = (double)entry.getValue() / words.length  * 100;
			System.out.printf("%1$s -> %2$.2f%%%n",entry.getKey(), frequency);
			
		}

	}

}
