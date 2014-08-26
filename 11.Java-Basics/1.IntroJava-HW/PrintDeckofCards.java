
public class PrintDeckofCards {

	public static void main(String[] args) {
		char[] suit = {'♠','♥','♦','♣'};
		for (int i = 2; i < 15; i++){
            for (int j = 0; j < 4; j++){
                switch (i){
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                    case 10: System.out.printf("%1$3s", i); break;
                    case 11: System.out.printf("%1$3s", "J"); break;
                    case 12: System.out.printf("%1$3s", "Q"); break;
                    case 13: System.out.printf("%1$3s", "K"); break;
                    case 14: System.out.printf("%1$3s", "A"); break;
                    default:
                        break;
                }

                System.out.print(suit[j] + " ");
            }
            System.out.println();
        }

	}

}
