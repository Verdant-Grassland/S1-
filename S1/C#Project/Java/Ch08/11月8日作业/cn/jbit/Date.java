package cn.jbit;

import java.util.Scanner;

public class Date {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入第一个数是:");
		int num1 = input.nextInt();
		System.out.println("输入第二个数是:");
		int num2 = input.nextInt();
		System.out.println("交换前: num1 = " + num1 + "，num2 = " + num2);
		int temp = num1;
		num1 = num2;
		num2 = temp;
		System.out.println("交换后: num1 = " + num1 + "，num2 = " + num2);
	}
}
