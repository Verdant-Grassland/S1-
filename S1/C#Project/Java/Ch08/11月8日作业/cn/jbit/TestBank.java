package cn.jbit;

import java.util.Scanner;

public class TestBank {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("=================��ӭʹ��MyBank���й���ϵͳ===============");
		System.out.println("1.��ʾ�����û�");
		System.out.println("2.���");
		System.out.println("3.ȡ��");
		System.out.println("4.�޸�����");
		System.out.println("5.��ѯ���");
		System.out.println("6.ת��");
		System.out.println("7.�˳�ϵͳ");
		System.out.println("====================================================");
		System.out.println("��ѡ������:");
		int num = input.nextInt();
		boolean flag;
		do{
		flag = false;
			switch(num){
				case 1:
					System.out.println("��ʾ�����û�");
					break;
				case 2:
					System.out.println("���");
					break;
				case 3:
					System.out.println("ȡ��");
					break;
				case 4:
					System.out.println("�޸�����");
					break;
				case 5:
					System.out.println("��ѯ���");
					break;
				case 6:
					System.out.println("ִ��ת��");
					break;
				case 7:
					System.out.println("�˳�ϵͳ");
					break;
				default:
					System.out.println("�������ִ�����������ѡ������:");
					num = input.nextInt();  
					flag = true;
			}
		}while(flag);
	}
}
