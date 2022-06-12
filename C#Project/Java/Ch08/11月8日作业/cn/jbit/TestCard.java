package cn.jbit;

import java.util.Scanner;

public class TestCard {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入您的名字:");
		String name = input.next();
		System.out.println("输入您的年龄:");
		int age = input.nextInt();
		System.out.println("输入您的邮箱:");
		String email = input.next();
		System.out.println("输入您的地址:");
		String address = input.next();
		System.out.println("输入您的工资:");
		int money = input.nextInt();
		System.out.println("我叫" + name + "，我住在" + address + "，我今年"+age+ "，我的邮箱是:" +email + "，我的工资" + money);
	}
}
