package cn.jbit;

import java.util.Scanner;

public class TestMenu {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Menu menu = new Menu();
		Manager manger = new Manager();
		manger.username = "admin";
		manger.password = "0000";
		menu.showLoginMenu();
		boolean flag;
		do{
	 		flag = false;
	 		int num = input.nextInt();
	 		switch(num) {
	 		case 1:
	 			System.out.println("�����û���:");
	 			String name = input.next();
	 			System.out.println("��������:");
	 			String pwd = input.next();
	 			if(name.equals(manger.username) && pwd.equals(manger.password)){
	 				System.out.println("��¼�ɹ����û���:" + name);
	 				menu.showMainMenu();
	 				break;
	 			}else{
	 				System.out.println("��û��Ȩ�޵�¼ϵͳ���û������������");
	 				menu.showLoginMenu();
	 			}
	 			break;
	 		case 2:
	 			System.out.println("�˳�");
	 			flag = false;
	 			break;
	 		}
	 	}while(flag);
	}
}
