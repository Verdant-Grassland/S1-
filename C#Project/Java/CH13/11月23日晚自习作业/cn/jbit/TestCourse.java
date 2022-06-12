package cn.jbit;

import java.util.Scanner;

public class TestCourse {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Course sum = new Course();
		System.out.println("输入您的java成绩:");
		int java = input.nextInt();
		System.out.println("输入您的html成绩:");
		int html = input.nextInt();
		System.out.println("输入您的sql成绩:");
		int sql = input.nextInt();
		int num = sum.calc(java, html, sql);
		System.out.println("您的总分数成绩是:" + num);
	}
}
