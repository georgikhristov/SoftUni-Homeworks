import java.util.Scanner;

public class SumTwoNumbers {
	public static void main(String[] args) {
        try(Scanner in = new Scanner(System.in);){
        int firstNum = in.nextInt();
        int secondNum = in.nextInt();
        System.out.println(firstNum + secondNum);
        }
    }
}
