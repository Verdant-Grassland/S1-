package cn.jbit;

import java.util.Scanner;

public class CopyOfTestConsole {

	public static void main(String[] args) {
		System.out.println("\t\t��ӭʹ���������ع������ϵͳ\n");
		System.out.println("\t\t\t1.��¼ϵͳ\n");
		System.out.println("\t\t\t2.�˳�\n");
		System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
		System.out.println("��ѡ���������֣�");
		Scanner input = new Scanner(System.in);
		if(input.hasNext()==true){
			int num = input.nextInt();
			switch (num){
				case 1:
					System.out.println("1.�ͻ���Ϣ����");
					System.out.println("2.�������");
					System.out.println("3.�������");
					System.out.println("4.ע��");
					break;
				case 2:
					System.out.println("�˳�ϵͳ��лл����ʹ�ã�");
				    break;
				  default:
				    System.out.println("�������");
				    break;
				}
			}else{
				System.out.println("��������ȷ�����֣�");
			}
		}
	}
