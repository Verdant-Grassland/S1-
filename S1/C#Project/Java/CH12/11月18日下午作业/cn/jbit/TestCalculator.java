package cn.jbit;

import java.util.Scanner;

public class TestCalculator {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Calculator Calc = new Calculator();
		System.out.println("第一个数:");
		Calc.sum = input.nextDouble();
		System.out.println("第二个数:");
		Calc.num = input.nextDouble();
		Calc.show();
	}
}
