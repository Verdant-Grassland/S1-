package cn.jbit;

import java.util.Scanner;

public class Person {
	String name;
	int age;
	int popularity;
	Scanner input = new Scanner(System.in);
	public String sayHi(){
		System.out.println("输入您的姓名:");
		String name = input.next();
		return name;
	}
	public int age(){
		System.out.println("\n输入您的年龄:");
		int age = input.nextInt();
		return age;
	}
	public int popularity(){
		System.out.println("\n输入您的人气值:");
		int popularity = input.nextInt();
		return popularity;
	}
}
