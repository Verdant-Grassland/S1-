package cn.jbit;

import java.util.Scanner;

public class TestCalculator {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Calculator Calc = new Calculator();
		System.out.println("��һ����:");
		Calc.sum = input.nextDouble();
		System.out.println("�ڶ�����:");
		Calc.num = input.nextDouble();
		Calc.show();
	}
}
