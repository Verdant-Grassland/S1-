package cn.jbit;

import java.util.Scanner;

public class Calc {
	double num1;
	double num2;
	public double Calculate(){
		double lc = 0;
		Scanner input = new Scanner(System.in);
		System.out.println("输入一个运算符:");
		char late = input.next().charAt(0);
		switch(late){
		case '+':
			System.out.println("两个数相加为:");
			lc = num1 + num2;
			break;
		case '-':
			System.out.println("两个数相减为:");
			lc = num1 - num2;
			break;
		case '*':
			System.out.println("两个数相乘为:");
			lc = num1 * num2;
			break;
		case '/':
			if(num1%2==0){
				System.out.println("除数不能为0");
			}else{
				System.out.println("两个数相除为");
			lc = num1 / num2;
			}
			break;
		}
		return lc;
	}
}
