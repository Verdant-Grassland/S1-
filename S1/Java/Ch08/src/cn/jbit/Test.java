package cn.jbit;

import java.util.Scanner;

public class Test {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("**************��ӭ����ѧϰ����ϵͳ***************");
		System.out.println("1.javavѧϰ");
		System.out.println("2.HTML��ҳ���");
		System.out.println("3.SQL���ݿ����");
		System.out.println("4.ע��");
		System.out.println("******************************************");
		System.out.println("��ѡ������:");
		int num = input.nextInt();
		boolean flag;
		do{
			flag = false;
			switch(num){
			case 1:
				System.out.println("ִ��javaѧϰ");
				break;
			case 2:
				System.out.println("ִ��HTML��ҳ���");
				break;
			case 3:
				System.out.println("ִ��SQL���ݿ����");
				break;
			default:
				System.out.println("�������ֲ���ȷ������������������:");
				num = input.nextInt();
				flag = true;
			}
		}while(flag);
		System.out.println("���������");
	}
}
