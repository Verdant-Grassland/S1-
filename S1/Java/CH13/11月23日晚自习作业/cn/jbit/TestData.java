package cn.jbit;

import java.util.Scanner;

public class TestData {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Data sum = new Data();
		System.out.println("�����һ����:");
		int num1 = input.nextInt();
		System.out.println("����ڶ�����:");
		int num2 = input.nextInt();
		sum.swap(num1, num2);
	}
}
