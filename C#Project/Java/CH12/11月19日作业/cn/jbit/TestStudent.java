package cn.jbit;

import java.util.Scanner;

public class TestStudent {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Student student = new Student();
		System.out.println("输入您的学号:");
		student.stuNo = input.nextInt();
		System.out.println("输入您的姓名:");
		student.name = input.next();
		System.out.println("输入您的年龄:");
		student.age = input.nextInt();
		System.out.println("输入您的性别:");
		student.sex = input.next();
		String Schools = student.getGrade();
		System.out.println(Schools);
	}
}
