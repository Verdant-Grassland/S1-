package cn.jbjc;

import java.util.Scanner;

public class Calc {
	double num1;
	double num2;
	public double calcNum(){
		double jg=0;
		Scanner input=new Scanner(System.in);
		System.out.println("����һ�������");
		char zf=input.next().charAt(0);
		switch(zf){
		case '+':
			System.out.println("���������Ϊ:");
			jg=num1+num2;
			break;
		case '-':
			System.out.println("���������Ϊ:");
			jg=num1-num2;
			break;
		case '*':
			System.out.println("���������Ϊ:");
			jg=num1*num2;
			break;
		case '/':
			if(num1%2==0){
				System.out.println("��������Ϊ0");
			}else{
				System.out.println("���������Ϊ");
				jg=num1/num2;
			}
			break;
		}
		return jg;
	}
}
