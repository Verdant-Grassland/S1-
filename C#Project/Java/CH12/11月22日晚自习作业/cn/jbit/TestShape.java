package cn.jbit;

import java.util.Scanner;

public class TestShape {

	public static void main(String[] args) {
		Scanner input = new Scanner (System.in);
		Shape shape = new Shape();
		System.out.println("��������");
		shape.row = input.nextInt();
		System.out.println("�������");
		shape.design = input.next();
		shape.printDesign();
	}
}