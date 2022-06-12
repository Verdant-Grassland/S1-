package cn.jbit;

import java.util.Scanner;

public class TestData {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Data sum = new Data();
		System.out.println("输入第一个数:");
		int num1 = input.nextInt();
		System.out.println("输入第二个数:");
		int num2 = input.nextInt();
		sum.swap(num1, num2);
	}
}
