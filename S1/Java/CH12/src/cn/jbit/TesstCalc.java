package cn.jbit;

import java.util.Scanner;

public class TesstCalc {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Calc calc = new Calc();
		System.out.println("输入第一个数:");
		calc.num1 = input.nextInt();
		System.out.println("输入第二数:");
		calc.num2 = input.nextInt();
		double late = calc.Calculate();
		System.out.println(late);
	}
}
