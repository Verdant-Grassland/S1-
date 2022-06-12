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
		System.out.print("输入第一个数");
		calc.num1=input.nextDouble();
		System.out.print("输入第二个数");
		calc.num2=input.nextDouble();
		double z=calc.calcNum();
		System.out.println(z);
	}

}
