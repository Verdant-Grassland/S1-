package cn.jbit;

import java.util.Scanner;

public class Persons {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入名字:");
		String name = input.next();
		System.out.println("输入身高:");
		String hight = input.next();
		System.out.println("输入武器:");
		String weapon = input.next();
		System.out.println("名字:" + name + "，身高:" + hight + "，武器:" + weapon);
	}
}
