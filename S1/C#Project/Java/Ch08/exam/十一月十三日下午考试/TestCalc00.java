package ʮһ��ʮ�������翼��;

import java.util.Scanner;

public class TestCalc00 {

	/**
	 * �˵��л�
	 */
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("*************��ӭ����ѧϰϵͳ*************");
		System.out.println("1.javaѧϰ");
		System.out.println("2.html��ҳ���");
		System.out.println("3.sql���ݿ����");
		System.out.println("4.ע��");
		System.out.println("*************************************");
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
				System.out.println("ִ��html��ҳ���");
				break;
			case 3:
				System.out.println("sql���ݿ����");
				break;
			case 4:
				System.out.println("ע��");
				break;
			default:
				System.out.println("���벻��ȷ������������ѡ������:");
				num = input.nextInt();
				flag = true;
			}
		}while(flag);
	}
}
