package cn.jbit;

import java.util.Scanner;

public class TestCard {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("������������:");
		String name = input.next();
		System.out.println("������������:");
		int age = input.nextInt();
		System.out.println("������������:");
		String email = input.next();
		System.out.println("�������ĵ�ַ:");
		String address = input.next();
		System.out.println("�������Ĺ���:");
		int money = input.nextInt();
		System.out.println("�ҽ�" + name + "����ס��" + address + "���ҽ���"+age+ "���ҵ�������:" +email + "���ҵĹ���" + money);
	}
}
