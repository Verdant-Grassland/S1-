package cn.jbit;

import java.util.Scanner;

public class Translator {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("* * * * * *��ӭʹ��Mini����* * * * * *");
		boolean weather = false;
		while(!weather){
			System.out.println("����������״���ĵ�һ��Ӣ����ĸ:");
			char letter = input.next().charAt(0);
			switch(letter){
			case 'D':
				System.out.println("����");
				break;
			case 'M':
				System.out.println("��ʪ");
				break;
			case 'H':
				System.out.println("����");
				break;
			case 'R':
				System.out.println("����");
				break;
			default:
				System.out.println("��������޷�ת��");
				break;
			}
			System.out.println("��������𣿣�y/n��");
			char junxian = input.next().charAt(0);
			if(junxian == 'n'){
				weather = false;
				System.out.println("�˳�ϵ�y");
				break;
			}
		}weather = true;
	}
}
