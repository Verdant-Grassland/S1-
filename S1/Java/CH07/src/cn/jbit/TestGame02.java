package cn.jbit;

import java.util.Scanner;

public class TestGame02 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int i = 1;
		int count = 0;
		int score = 0;
		String answer;
		System.out.println("����������Ϸƽ̨ > ��Ϸ����\n");
		 do{
			System.out.print("���������" + i + "��,�ɼ�Ϊ�� ");
			score = input.nextInt();
			if (score >= 80) {
				count++;
			}
			i++;
			if (i > 5) {
				System.out.print("��Ϸ����");
			} else {
				System.out.print("��������һ����(yes/no) ");
				answer = input.next();
				if (answer.equals("no")) {
					System.out.print("���Ѿ���;�˳���Ϸ��");
					break;
				} else {
					System.out.println("������һ��");
				}
			}

		}while (i <= 5);

		double rate = count / 5.0;
		if (i > 5) {
			if (rate > 0.8) {
				System.out.println("\n����Ϊһ��");
			} else if (rate > 0.6) {
				System.out.println("\n����Ϊ����");
			} else {
				System.out.println("\n���ܽ���");
			}
		} else {
			System.out.println("\n������5��");
		}
	}
}
