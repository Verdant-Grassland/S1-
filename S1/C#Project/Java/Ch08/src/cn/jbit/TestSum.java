package cn.jbit;

import java.util.Scanner;

public class TestSum {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int i = 0;
		int sum = 0;
		for (i = 0 ; i < 5 ; i++){
			System.out.println("请输入第" + (i+1) + "个同学分数:");
			int score = input.nextInt();
			sum = sum + score;
		}
		double avg = sum / 5;
		System.out.println("总分是:" + sum);
		System.out.println("平均分是:" + avg);
	}
}
