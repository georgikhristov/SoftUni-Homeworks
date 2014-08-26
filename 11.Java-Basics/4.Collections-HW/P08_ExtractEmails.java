import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class P08_ExtractEmails {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String user = "([a-zA-Z0-9]+[._-]*[a-zA-Z0-9]+)+([._-]*[a-zA-Z0-9]+)*";
		String host = "\\w+[-.]*\\w+[.]+\\w+[-.]*\\w+";
		String regex = user + "@" + host;
		String text = input.nextLine();
		Pattern phonePattern = Pattern.compile(regex);
		Matcher matcher = phonePattern.matcher(text);
		while (matcher.find()) {
			System.out.println(matcher.group());
		}

	}

}
