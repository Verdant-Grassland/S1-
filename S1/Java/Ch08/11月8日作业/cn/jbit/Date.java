package cn.jbit;

import java.util.Scanner;

public class Date {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("�����һ������:");
		int num1 = input.nextInt();
		System.out.println("����ڶ�������:");
		int num2 = input.nextInt();
		System.out.println("����ǰ: num1 = " + num1 + "��num2 = " + num2);
		int temp = num1;
		num1 = num2;
		num2 = temp;
		System.out.println("������: num1 = " + num1 + "��num2 = " + num2);
	}
}
