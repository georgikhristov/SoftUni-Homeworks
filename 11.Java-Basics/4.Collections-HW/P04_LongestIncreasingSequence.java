import java.util.Scanner;

public class P04_LongestIncreasingSequence {

	public static void main(String[] args) {
		try (Scanner input = new Scanner(System.in);) {
			/* constructing an array of numbers */
			String[] strs = input.nextLine().split(" ");
			int[] numbers = new int[strs.length];
			for (int i = 0; i < strs.length; i++) {
				numbers[i] = Integer.parseInt(strs[i]);
			}
			
			String max = ""; // holds the max sequence in a string
			int maxLength = 0;
			int currentLength = 1;
			
			for (int i = 0, j = 0; i < numbers.length; i++) {
				
				/* searching for current longest increasing sequence*/
				for (j = i+1; j < numbers.length; j++) {
					if (numbers[j-1] < numbers[j]) {
						currentLength++;
					} else break;
				}
				
				/* printing current sequence*/
				for (int k = j- currentLength; k < j; k++) {
					System.out.print(numbers[k]+ " ");
				}
				System.out.println();
				
				/*checking if current sequence is bigger than max*/
				if (currentLength > maxLength) {
					/*constructing max sequence*/
					maxLength = currentLength;
					max = "";
					for (int k = i; k < maxLength + i; k++) {
						max += numbers[k] + " ";
					}
				}
				
				/*initializing*/
				currentLength = 1;
				i = j - 1; //to start checking from where the old sequence broke
			}
			
			/*printing max sequence*/
			System.out.println("Longest: " + max);
		}
	}

}
