package cn.jbit;

import java.util.Scanner;

public class Tests02 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("*******************��ӭ���������ϵͳ*******************");
		System.out.println("1.���ӻ�������");
		System.out.println("2.��ѯ���û�������");
		System.out.println("3.��Ʒ���");
		System.out.println("4.��Ʒ����");
		System.out.println("5.�˳�ϵͳ");
		System.out.println("****************************************************");
		System.out.println("��ѡ������:");
		int num = input.nextInt();
		boolean shopping;
		do{
			shopping = false;
			switch(num){
			case 1:
				System.out.println("�������ӻ�������");
				break;
			case 2:
				System.out.println("�����ѯ���л�������");
				break;
			case 3:
				System.out.println("������Ʒ���");
				break;
			case 4:
				System.out.println("������Ʒ����");
				break;
			case 5:
				System.out.println("�˳�ϵͳ");
				break;
			default:
				System.out.println("���ִ�������������ѡ������:");
				num = input.nextInt();
				shopping = true;
			}
		}while(shopping);
	}
}
