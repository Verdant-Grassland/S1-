package cn.jbit;

import java.util.Scanner;

public class LuckBuy302 {

	/**
	 * ���˴󽱣�δ��ȫ�ɣ�
	 */
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String answer = "y";
		String userName = "";
		String password = "";
		int max = 9999;
		int min = 1000;
		boolean isRegister = false;
		boolean isLogin = false;
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
			System.out.println("����д����ע����Ϣ:");
			System.out.println("�û���:");
			userName = input.next();
			System.out.print("����:");
			password = input.next();
			int cardNumber = (int)(Math.random()*(max-min)) +min;
			System.out.println("\nע��ɹ�����Ǻ����Ļ�Ա����");
			System.out.println("�û���\t����\t��Ա����");
			System.out.println(userName + "\t" + password + "\t" + cardNumber);
			isRegister = true;
			break;
		case 2:
			System.out.println("[���͸���ϵͳ > ��¼]");
			if(isRegister){
				for(int i = 1 ; i <= 3 ; i++){
					System.out.println("�������û���:");
					String inputName = input.next();
					System.out.println("����������:");
					String inputPassWord = input.next();
					if(userName.equals(inputName) && password.equals(inputPassWord)){
						System.out.println("\n��ӭ��:" + userName);
						isLogin = true;
						break;
					}else{
						System.out.println("�û�����������󣬻���" + (3 - i) + "�λ���!");
					}
					if(i == 3){
						System.out.println("�����û��������������");
					}  
				}
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