package cn.jbit;

public class TestWhile {
	
	public static void main(String[] args) {
		int sum = 0;
		int num = 0;
		while(num <= 100) {
			sum = sum + num;
			num = num + 2;
		}
		System.out.println("100以内的偶数之和为:"+sum);
	}
}
 