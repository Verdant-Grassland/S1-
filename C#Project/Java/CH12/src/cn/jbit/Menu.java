package cn.jbit;

import java.util.Scanner;

public class Menu {
	Scanner input = new Scanner(System.in);
	public void showLoginMenu(){
		System.out.println("\n\t��ӭʹ���������ع������ϵͳ\n");
		System.out.println("\t\t 1. �� ¼ ϵ ͳ\n");
		System.out.println("\t\t 2. �� ��\n");
		System.out.println ("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
		System.out.print("��ѡ��,��������:");
	}
	public void showMainMenu(){
	  	System.out.println("\n\t�������ع������ϵͳ���˵�\n");
	 	System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
	 	System.out.println("\t\t 1. �� �� �� Ϣ �� ��\n"); 		
	 	System.out.println("\t\t 2. �� �� �� ��\n"); 		
	 	System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
	 	System.out.print("��ѡ��,�������ֻ�0������һ���˵�:"); 		
	 	int num = input.nextInt();
	 	boolean flag;
	 	do{
	 		flag = false;
	 		switch(num) {
	 		case 1:
	 			ShowCustMenu();
	 			break;
	 		case 2:
	 			showLoginMenu();
	 			break;
	 		case 0:
	 			showLoginMenu();
	 			break;
	 		default:
	 			System.out.println("�˵�ѡ���������������:");
	 			num = input.nextInt();
	 			flag = true;
	 			break;
	 		}
	 	}while(flag);
	}
	
	public void ShowCustMenu(){
	 	System.out.println("\n\t�������ع������ϵͳ > �ͻ���Ϣ����");
	 	System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
	 	System.out.println("\t\t  1. �� ʾ �� �� �� �� �� Ϣ\n");
	 	System.out.println("\t\t  2. �� �� �� �� �� Ϣ\n");
	 	System.out.println("\t\t  3. �� �� �� �� �� Ϣ\n");
	 	System.out.println("\t\t  4. �� ѯ �� �� �� Ϣ\n");
	 	System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
	 	System.out.print("��ѡ��,�������ֻ�0������һ���˵�:");
	 	int num = input.nextInt();
	 	boolean flag;
	 	do{
	 		flag = false;
	 		switch(num) {
	 		case 1:
	 			System.out.println("ִ���� ʾ �� �� �� �� �� Ϣ");
	 			break;
	 		case 2:
	 			System.out.println("ִ���� �� �� �� �� Ϣ");
	 			break;
	 		case 3:
	 			System.out.println("ִ���� �� �� �� �� Ϣ");
	 			break;
	 		case 4:
	 			System.out.println("ִ�� �� ѯ �� �� �� Ϣ");
	 			break;
	 		case 0:
	 			showMainMenu();
	 			break;
	 		default:
	 			System.out.println("�˵�ѡ���������������:");
	 			num = input.nextInt();
	 			flag = true;
	 			break;
	 		}
	 	}while(flag);
	}
	
	public void showSendGMenu(){
		 System.out.println("\n\t�������ع������ϵͳ > �������");
		 System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
		 System.out.println("\t\t 1. �� �� �� �� ��\n");
		 System.out.println("\t\t 2. �� �� �� ��\n");
		 System.out.println("\t\t 3. �� �� �� ��\n");
		 System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
		 System.out.print("��ѡ��,�������ֻ�0������һ���˵���");
		 int num = input.nextInt();
		 boolean flag;
		 do{
			 flag = false;
			 switch(num){
			 case 1:
		 		System.out.println("ִ���� �� �� �� ��");
		 		break;
		 	case 2:
		 		System.out.println("ִ���� �� �� ��");
		 		break;
		 	case 3:
		 		System.out.println("ִ���� �� �� ��");
		 		break;
		 	case 0:
		 		showMainMenu();
		 		break;
		 	default:
		 		System.out.println("�˵�ѡ���������������:");
		 		num = input.nextInt();
		 		flag = true;
		 		break;
		 	}
		}while(flag);	
	}
}

