package cn.jbjc;

import java.util.Scanner;

public class TextCalc {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Scanner input=new Scanner (System.in);
		Calc calc=new Calc();
		System.out.print("�����һ����");
		calc.num1=input.nextDouble();
		System.out.print("����ڶ�����");
		calc.num2=input.nextDouble();
		double z=calc.calcNum();
		System.out.println(z);
	}

}
