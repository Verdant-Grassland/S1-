package cn.jbit;

import java.util.Scanner;

public class GameUser {

	public static void main(String[] args) {
		System.out.println("����������Ϸƽ̨ > ����û���Ϣ\n");
		int custNo = 0;
		int age;
		int points = 0;
		System.out.println("������Ҫ¼���û�������:");
		Scanner input = new Scanner(System.in);
		int count = input.nextInt();
		for (int i = 0 ; i < count ; i++) {
			System.out.println("�������û����(<4λ����:>)");
			custNo = input.nextInt();
			System.out.println("�������û�����:");
			age = input.nextInt();
			if (age < 10 || age > 100) {
				System.out.println("�ܱ�Ǹ���������䲻��������Ϸ");
				System.out.println("¼����Ϣʧ��\n");
				continue;
			}
			System.out.println("�������Ա����:");
			points = input.nextInt();
			System.out.println("��¼��Ļ�Ա��Ϣ��:");
			System.out.println("�û����:" + custNo + "\t����:" + age + "\t����:" + points + "\n");
		}
	}
}
