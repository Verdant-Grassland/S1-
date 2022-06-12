package cn.jbit;

import java.util.Scanner;

public class TestMenu {

	public static void main(String[] args) {
		System.out.println("*******************欢迎青鸟学习管理系统********************");
		System.out.println("\t1.Java学习");
		System.out.println("\t2.HTML网页设计");
		System.out.println("\t3.SQL数据库基础");
		System.out.println("\t4.注销");
		System.out.println("****************************************************");
		int User;
		boolean isRight;
		System.out.println("请选择，输入数字:");
		Scanner input = new Scanner(System.in); 
		do{
			isRight = true;
			User = input.nextInt();
			switch(User) {
			case 1:
				System.out.println("Java学习");
				break;
			case 2:
				System.out.println("HTML网页设计");
				break;
			case 3:
				System.out.println("SQL数据库基础");
				break;
			case 4:
				System.out.println("注销");
				break;
			default:
				System.out.println("输入错误，请重新输入数字:");
				isRight = false;
			}
			
		}while(!isRight);
		System.out.println("\n程序结束");
	}
}
