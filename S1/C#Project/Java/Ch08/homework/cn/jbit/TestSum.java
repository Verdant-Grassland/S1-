package cn.jbit;

import java.util.Scanner;

public class TestSum {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入一个4位数:");
		int sum = input.nextInt();
		int qian = sum / 1000;
		int bai = sum / 100%10;
		int shi = sum / 10%10;
		int ge = sum%10;
		System.out.println(qian + bai + shi + ge);
	}
}
