package cn.jbit;

import java.util.Scanner;

public class TestMenu {

	public static void main(String[] args) {
		System.out.println("*******************��ӭ����ѧϰ����ϵͳ********************");
		System.out.println("\t1.Javaѧϰ");
		System.out.println("\t2.HTML��ҳ���");
		System.out.println("\t3.SQL���ݿ����");
		System.out.println("\t4.ע��");
		System.out.println("****************************************************");
		int User;
		boolean isRight;
		System.out.println("��ѡ����������:");
		Scanner input = new Scanner(System.in); 
		do{
			isRight = true;
			User = input.nextInt();
			switch(User) {
			case 1:
				System.out.println("Javaѧϰ");
				break;
			case 2:
				System.out.println("HTML��ҳ���");
				break;
			case 3:
				System.out.println("SQL���ݿ����");
				break;
			case 4:
				System.out.println("ע��");
				break;
			default:
				System.out.println("���������������������:");
				isRight = false;
			}
			
		}while(!isRight);
		System.out.println("\n�������");
	}
}
