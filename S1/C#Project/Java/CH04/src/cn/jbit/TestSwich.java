package cn.jbit;

import java.util.Scanner;

public class TestSwich {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("�������Σ�");
		int mingCi=input.nextInt();
		switch(mingCi){
		case 1:
			System.out.println("��ʡ����ѧ��֯��1��������Ӫ");
			break;
		case 2:
			System.out.println("�������ձʼǱ�����һ��");
			break;
		case 3:
			System.out.println("�����ƶ�Ӳ��һ��");
			break;
		default:
			System.out.println("û���κν���");
			break;
		}
	}

}
