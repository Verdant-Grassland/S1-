package cn.jbit;

import java.util.Scanner;

public class TestShape {

	public static void main(String[] args) {
		Scanner input = new Scanner (System.in);
		Shape shape = new Shape();
		System.out.println("输入行数");
		shape.row = input.nextInt();
		System.out.println("输入符号");
		shape.design = input.next();
		shape.printDesign();
	}
}