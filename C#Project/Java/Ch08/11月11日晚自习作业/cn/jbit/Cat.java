package cn.jbit;

import java.util.Scanner;

public class Cat {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("��������:");
		String name = input.next();
		System.out.println("������ɫ:");
		String color = input.next();
		System.out.println("��������:");
		int age = input.nextInt();
		System.out.println("����:" + name);
		System.out.println("��ɫ:" + color);
		System.out.println("����:" + age);
	}
}
