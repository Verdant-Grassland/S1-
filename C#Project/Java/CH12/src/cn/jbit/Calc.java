package cn.jbit;

import java.util.Scanner;

public class Calc {
	double num1;
	double num2;
	public double Calculate(){
		double lc = 0;
		Scanner input = new Scanner(System.in);
		System.out.println("����һ�������:");
		char late = input.next().charAt(0);
		switch(late){
		case '+':
			System.out.println("���������Ϊ:");
			lc = num1 + num2;
			break;
		case '-':
			System.out.println("���������Ϊ:");
			lc = num1 - num2;
			break;
		case '*':
			System.out.println("���������Ϊ:");
			lc = num1 * num2;
			break;
		case '/':
			if(num1%2==0){
				System.out.println("��������Ϊ0");
			}else{
				System.out.println("���������Ϊ");
			lc = num1 / num2;
			}
			break;
		}
		return lc;
	}
}
