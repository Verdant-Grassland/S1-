package cn.jbit;

import java.util.Scanner;

public class TestGame {

	public static void main(String[] args) {
		System.out.println("��ӭ����������Ϸ����Ϸƽ̨");
		System.out.println("��ѡ����ϲ������Ϸ:\n");
		System.out.println("***************************************************");
		System.out.println("1.������");
		System.out.println("2.��ţ");
		System.out.println("3.������");
		System.out.println("4.������");
		System.out.println("***************************************************");
		int choice;	
		boolean isRight;
		System.out.print("��ѡ���������֣�");
		Scanner input = new Scanner(System.in);
		do{
			isRight = true;
			choice = input.nextInt();
			switch (choice) {
			case 1:
				System.out.println("���ѽ��붷��������");
				break;
			case 2:
				System.out.println("���ѽ��붷ţ����");
				break;
			case 3:
				System.out.println("���ѽ�������������");
				break;
			case 4:
				System.out.println("���ѽ�������������");
				break;
			default:
				System.out.print("��������������������֣�");
				isRight = false;
				break;
			}
		}while(!isRight);
	}
}
