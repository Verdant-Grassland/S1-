package cn.jbit;

import java.util.Scanner;

public class Menu {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		boolean flag;
		System.out.println("*******************************");
		System.out.println("\t1.�� �� �� Ϣ �� ��");
		System.out.println("\t2.�� �� �� ��");
		System.out.println("\t3.�� �� �� ��");
		System.out.println("\t4.ע ��");
		System.out.println("*******************************\n");
		System.out.print("��ѡ���������֣�");
		int num = input.nextInt();
		do{
			flag = false;
			switch(num){
			case 1:
				System.out.println("ִ�пͻ���Ϣ����");
				break;
			case 2:
				System.out.println("ִ�й������");
				break;
			case 3:
				System.out.println("ִ���������");
				break;
			case 4:
				System.out.println("ִ��ע��");
				break;
			default:
				System.out.print("��������������������֣�");
				num = input.nextInt();
				flag = true;
				break;
			}
		}while(flag);
	}
}