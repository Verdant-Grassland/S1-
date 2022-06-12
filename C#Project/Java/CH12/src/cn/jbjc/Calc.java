package cn.jbjc;

import java.util.Scanner;

public class Calc {
	double num1;
	double num2;
	public double calcNum(){
		double jg=0;
		Scanner input=new Scanner(System.in);
		System.out.println("输入一个运算符");
		char zf=input.next().charAt(0);
		switch(zf){
		case '+':
			System.out.println("两个数相加为:");
			jg=num1+num2;
			break;
		case '-':
			System.out.println("两个数相减为:");
			jg=num1-num2;
			break;
		case '*':
			System.out.println("两个数相乘为:");
			jg=num1*num2;
			break;
		case '/':
			if(num1%2==0){
				System.out.println("除数不能为0");
			}else{
				System.out.println("两个数相除为");
				jg=num1/num2;
			}
			break;
		}
		return jg;
	}
}
