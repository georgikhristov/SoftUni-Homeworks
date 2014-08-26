import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;


public class P11_MostFrequentWord {

	public static void main(String[] args) {
		try(Scanner input = new Scanner(System.in);){
			String[] words = input.nextLine().toLowerCase().split("\\W+");
			TreeMap<String, Integer> unique = new TreeMap<>();
			int maxCount = 0;
			for (String word : words) {
				if (unique.containsKey(word)) {
					unique.replace(word, unique.get(word) + 1);
				} else {
					unique.put(word, 1);
				}
				if (unique.get(word) > maxCount) {
					maxCount = unique.get(word);
				}	
			}
			for (Map.Entry<String, Integer> entry : unique.entrySet()) {
				if (entry.getValue() == maxCount) {
					System.out.println(entry.getKey() + " -> " 
							+ entry.getValue() + " times");
				}
			}
		}

	}

}
