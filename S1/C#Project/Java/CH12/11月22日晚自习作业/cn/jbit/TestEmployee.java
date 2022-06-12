package cn.jbit;

import java.util.Scanner;

public class TestEmployee {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Employee work = new Employee();
		System.out.println("输入您的职工号:");
		work.empNo = input.nextInt();
		System.out.println("输入您的姓名:");
		work.name = input.next();
		System.out.println("输入您的性别:");
		work.sex = input.next();
		System.out.println("输入您的人气值:");
		work.popularity = input.nextInt();
		work.show();
	}
}
