package cn.jbit;

import java.util.Scanner;

public class Drink {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("�������ϵ�����:");
		String drink = input.next();
		switch (drink){
			case "����":
				System.out.println("��");
				break;
			case "ţ��":
				System.out.println("��");
				break;
			case "����":
				System.out.println("��");
				break;
		}
	}
}