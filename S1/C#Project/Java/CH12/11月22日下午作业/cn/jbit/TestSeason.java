package cn.jbit;

import java.util.Scanner;

public class TestSeason {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Season four = new Season();
		System.out.print("�������·�:");
		int month = input.nextInt();
		switch(month){
		case 3:
		case 4:
		case 5:
			System.out.println(four.Spring());
			break;
		case 6:
		case 7:
		case 8:
			System.out.println(four.Summber());
			break;
		case 9:
		case 10:
		case 11:
			System.out.println(four.Autumn());
			break;
		case 12:
		case 1:
		case 2:
			System.out.println(four.Winter());
			break;
		default:
			System.out .println("��������������1~12�·�����");
			break;
		}
	}
}
