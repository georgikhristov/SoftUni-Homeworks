import java.util.Scanner;

public class P03_LargestSequenceOfEqualStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] strs = input.nextLine().split(" ");
		String max = "";
		int maxLength = 0;
		int currentLength = 0;
		for (int i = 0, j = 0; i < strs.length; i++) {
			for (j = i; j < strs.length; j++) {
				if (strs[i].equals(strs[j])) {
					currentLength++;
					if (currentLength > maxLength) {
						maxLength = currentLength;
						max = "";
						for (int k = 0; k < maxLength; k++) {
							max += strs[j] + " ";
						}
					}
				} else break;
			}
			currentLength = 0;
			i = j - 1;
		}
		System.out.println(max);
	}
}
