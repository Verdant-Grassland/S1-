package cn.jbit;

import java.util.Scanner;

public class TestCalculator01 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Calculator01 calc = new Calculator01();
		System.out.println("�����һ����:");
		calc.num1 = input.nextInt();
		System.out.println("����ڶ�����:");
		calc.num2 = input.nextInt();
		System.out.println("���������:" + calc.add());
		System.out.println("���������:" + calc.minus());
		System.out.println("���������:" + calc.multiple());
		System.out.println("���������:" + calc.divide());
	}
}
