package cn.jbit;

import java.util.Scanner;

public class TestCalcScore {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		CalcScore calc = new CalcScore();
		System.out.println("������Java�ĳɼ�:");
		calc.Java = input.nextInt();
		System.out.println("������C#�ĳɼ�:");
		calc.C = input.nextInt();
		System.out.println("������DB�ĳɼ�:");
		calc.DB = input.nextInt();
		calc.showSum();
		calc.showAvg();
	}
}
