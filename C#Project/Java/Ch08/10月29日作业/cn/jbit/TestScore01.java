package cn.jbit;

import java.util.Scanner;

public class TestScore01 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int sum = 0;
		for (int i = 1 ; i <= 10 ; i++) {
			System.out.println("第" + i + "位同学成绩是:");
			int score = input.nextInt();
			if (score >= 90) {
				sum++;
			}
		}
		double ber = (sum/10.0) * 100;
		System.out.println("大于90分的人数是:" + sum);
		System.out.println("大于90分人数的比例是:" + ber + "%");
	}
}
