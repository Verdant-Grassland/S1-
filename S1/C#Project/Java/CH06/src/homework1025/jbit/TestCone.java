package homework1025.jbit;

public class TestCone {

	public static void main(String[] args) {
		int sum = 0;
		for (int i = 1 ; i <= 10 ; i++) {
			if (i % 2 == 1) {
				continue;
			}
			sum = sum + i;
		}
		System.out.println("1——10之间的偶数和是:" + sum);
	}
}
