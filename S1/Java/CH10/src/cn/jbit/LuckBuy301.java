package cn.jbit;

import java.util.Scanner;

public class LuckBuy301 {

	/**
	 * ���˴󽱣�δ��ȫ�ɣ�
	 */
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String answer = "y";
		int max = 9999;
		int min = 1000;
		while(answer.equals("y")){
		System.out.println("*****��ӭ���뽱�͸���ϵͳ*****");
		System.out.println("\t1.ע��");
		System.out.println("\t2.��¼");
		System.out.println("\t3.�齱");
		System.out.println("***********************");
		System.out.println("��ѡ��˵�:");
		int choice = input.nextInt();
		String userName = "";
		String password = "";
		int cardNumber = (int)(Math.random()*(max-min)) +min;
		boolean isRegister = false;
		switch(choice){
		case 1:
			System.out.println("[���͸���ϵͳ > ע��]");
			System.out.println("����д����ע����Ϣ:");
			System.out.println("�û���:");
			userName = input.next();
			System.out.print("����:");
			password = input.next();
			System.out.println("\nע��ɹ�����Ǻ����Ļ�Ա����");
			System.out.println("�û���\t����\t��Ա����");
			System.out.println(userName + "\t" + password + "\t" + cardNumber);
			isRegister = true;
			break;
		case 2:
			System.out.println("[���͸���ϵͳ > ��¼]");
			if(isRegister){
				
			}else{
				System.out.println("����û��ע���أ����ܵ�¼");
			}
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

