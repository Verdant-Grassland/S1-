package cn.jbit;

import java.util.Scanner;

public class TestCalcScore {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		CalcScore calc = new CalcScore();
		System.out.println("请输入Java的成绩:");
		calc.Java = input.nextInt();
		System.out.println("请输入C#的成绩:");
		calc.C = input.nextInt();
		System.out.println("请输入DB的成绩:");
		calc.DB = input.nextInt();
		calc.showSum();
		calc.showAvg();
	}
}
