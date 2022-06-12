package cn.jbit;

import java.util.Scanner;

public class TestEncryption {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入数字:");
		int num = input.nextInt();
		int qian = (num /  1000 % 10 + 9) %10;
		int bai = (num / 100 % 10 + 9) %10;
		int shi = (num / 10 % 10 + 9) %10;
		int ge = (num % 10 + 9) %10;
		int num1 = qian;
		qian = shi;
		shi = num1;
		int num2 = bai;
		bai = ge;
		ge = num2;
			System.out.println("请输入是:" + qian + bai + shi + ge);
	}
}
