package cn.jbit;

import java.util.Scanner;

public class Textwhile {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("�ϸ�����?(y/n)��");
		String answer = input.next();
		while(!"y".equals(answer)) {
			System.out.println("�����Ķ��̲ģ�");
			System.out.println("�����ϻ���̣�\n");
			System.out.print("�ϸ�����?(y/n)��");
			answer = input.next();
		}
		System.out.println("���ѧϰ����");
	}
}
