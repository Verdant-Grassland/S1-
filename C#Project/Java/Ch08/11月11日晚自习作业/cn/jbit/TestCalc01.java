package cn.jbit;

import java.util.Scanner;

public class TestCalc01 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("=================��ӭʹ���û�����ϵͳ=================");
		System.out.println("\t\t1.�����û�");
		System.out.println("\t\t2.�鿴�����û���Ϣ");
		System.out.println("\t\t3.�޸��û���");
		System.out.println("\t\t4.���û�����ѯ������Ϣ");
		System.out.println("\t\t5.�˳�");
		System.out.println("================================================");
		System.out.println("��ѡ������:");
		int choice = input.nextInt();
		boolean num;
		do{
			num = false;
			switch(choice){
			case 1:
				System.out.println("�������������û�");
				break;
			case 2:
				System.out.println("����鿴�����û���Ϣ");
				break;
			case 3:
				System.out.println("�����޸��û���");
				break;
			case 4:
				System.out.println("���밴�û�����ѯ������Ϣ");
				break;
			case 5:
				System.out.println("�˳���¼");
				break;
			default:
				num = false;
				System.out.println("ѡ�����ִ�����������������:");
				choice = input.nextInt();
				break;
			}
		}while(num);
	}
}
