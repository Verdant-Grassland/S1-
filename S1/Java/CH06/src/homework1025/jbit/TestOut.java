package homework1025.jbit;

public class TestOut {

	public static void main(String[] args) {
		int sum = 0;
		for (int i = 1; i <= 10; i++) {
			sum = sum + i;
			if (sum > 20) {
				System.out.print("当前数是:" + i);
				break;
			}
		}
	}
}
