package cn.jbit;

import java.util.Scanner;

public class Test {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("**************欢迎青鸟学习管理系统***************");
		System.out.println("1.javav学习");
		System.out.println("2.HTML网页设计");
		System.out.println("3.SQL数据库基础");
		System.out.println("4.注销");
		System.out.println("******************************************");
		System.out.println("请选择数字:");
		int num = input.nextInt();
		boolean flag;
		do{
			flag = false;
			switch(num){
			case 1:
				System.out.println("执行java学习");
				break;
			case 2:
				System.out.println("执行HTML网页设计");
				break;
			case 3:
				System.out.println("执行SQL数据库基础");
				break;
			default:
				System.out.println("输入数字不正确，请您重新输入数字:");
				num = input.nextInt();
				flag = true;
			}
		}while(flag);
		System.out.println("程序结束！");
	}
}
