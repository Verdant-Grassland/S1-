package cn.jbit;

import java.util.Scanner;

public class Myshopping2 {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String answer = "y";	
		int shirtPrice = 245;
		int shoePrice = 570;
		int padPrice = 320;
		int shirtNo = 2;
		int shoeNo =1;
		int padNo = 1; 
		double total = 0;
		double money = 0;
		while(answer.equals("y")) {
			System.out.println("*******************************************");
			System.out.println("��ѡ�������Ʒ��ţ�");
			System.out.println("1.T��        2.����Ь        3.������");
			System.out.println("*******************************************");
		
			System.out.println("��������Ʒ���:");
			int num = input.nextInt();
			System.out.println("��������Ʒ����:");
			int count = input.nextInt();
			switch(num){
			case 1:
				money = shirtPrice * count;
				System.out.println("T�� \t��"+shirtPrice+"\t����"+count+"\t�ϼ�"+money);
				break;
			case 2:
				System.out.println("����Ь\t��"+padPrice+"\t����"+count+"\t�ϼ�"+money);
				break;
			case 3:
				System.out.println("������ \t��"+padPrice+"\t����"+count+"\t�ϼ�"+money);
				break;
			default:
				System.out.println("û�д˲˵���");
				break;
			}
			total = total + money;
			System.out.println("�Ƿ����(y/n)");
			answer = input.next();
		}
		System.out.println("�ۿ�:0.3");
		total = total * 0.3;
		System.out.println("Ӧ�����:"+total);
		System.out.println("ʵ�����:");
		int pay = input.nextInt();
		System.out.println("����:"+(pay-total));
	}
}
