package cn.jbit;

import java.util.Scanner;

public class TesstCalc {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Calc calc = new Calc();
		System.out.println("�����һ����:");
		calc.num1 = input.nextInt();
		System.out.println("����ڶ���:");
		calc.num2 = input.nextInt();
		double late = calc.Calculate();
		System.out.println(late);
	}
}
