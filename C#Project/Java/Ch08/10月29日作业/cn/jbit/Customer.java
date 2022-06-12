package cn.jbit;

import java.util.Scanner;

public class Customer {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入会员的积分:");
		int score = input.nextInt();
		if (score >= 100 && score <= 1000) {
			System.out.println("普卡");
		}else if (score >= 1001 && score <= 3000) {
			System.out.println("银卡");
		}else if (score >= 3001 && score <= 5000) {
			System.out.println("金卡");
		}
	}
}
