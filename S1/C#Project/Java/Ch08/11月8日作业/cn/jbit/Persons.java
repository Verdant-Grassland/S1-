package cn.jbit;

import java.util.Scanner;

public class Persons {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("��������:");
		String name = input.next();
		System.out.println("�������:");
		String hight = input.next();
		System.out.println("��������:");
		String weapon = input.next();
		System.out.println("����:" + name + "�����:" + hight + "������:" + weapon);
	}
}
