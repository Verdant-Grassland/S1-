package cn.jbit;

import java.util.Scanner;

public class Cat {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入名字:");
		String name = input.next();
		System.out.println("输入颜色:");
		String color = input.next();
		System.out.println("输入年龄:");
		int age = input.nextInt();
		System.out.println("名字:" + name);
		System.out.println("颜色:" + color);
		System.out.println("年龄:" + age);
	}
}
