import java.util.Scanner;


public class P02_SequenceOfEqualStrings {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] strs = input.nextLine().split(" ");
		for (int i = 0, j = 0; i < strs.length; i++) {
			for (j = i; j < strs.length; j++) {
				if (strs[i].equals(strs[j])) {
					System.out.print(strs[j] + " ");
				}
				else break;
			}
			System.out.println();
			i = j - 1;
		}

	}

}
