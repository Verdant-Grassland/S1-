package cn.jbit;

import java.util.Scanner;

public class LuckBuy2 {

	/**
	 * ���˴󽱣�δ��ȫ�ɣ�
	 */
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String answer = "y";
		while(answer.equals("y")){
		System.out.println("*****��ӭ���뽱�͸���ϵͳ*****");
		System.out.println("\t1.ע��");
		System.out.println("\t2.��¼");
		System.out.println("\t3.�齱");
		System.out.println("***********************");
		System.out.println("��ѡ��˵�:");
		int choice = input.nextInt();
		switch(choice){
		case 1:
			System.out.println("[���͸���ϵͳ > ע��]");
			break;
		case 2:
			System.out.println("[���͸���ϵͳ > ��¼]");
			break;
		case 3:
			System.out.println("[���͸���ϵͳ > �齱]");
			break;
		default:
			System.out.println("[������������!]");
			break;
		}
		System.out.println("������(y/n):");
		answer = input.next();
		}
		System.out.println("ϵͳ�˳���ллʹ�ã�");
	}
}

