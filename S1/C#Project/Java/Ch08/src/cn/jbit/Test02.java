package cn.jbit;

import java.util.Scanner;

public class Test02 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int score = 0;
		for (int i = 1 ; i <= 5 ; i++){
			System.out.println("输入第" + i + "个同学的分数:");
			int sore = input.nextInt();
			if (sore >= 60) {
				score++;
			}
		}
		double count = score / 5.0;
		System.out.println("及格同学比例是:" + count * 100 + "%");
	}
}
