package cn.jbit;

import java.util.Scanner;

public class TestScore01 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int sum = 0;
		for (int i = 1 ; i <= 10 ; i++) {
			System.out.println("��" + i + "λͬѧ�ɼ���:");
			int score = input.nextInt();
			if (score >= 90) {
				sum++;
			}
		}
		double ber = (sum/10.0) * 100;
		System.out.println("����90�ֵ�������:" + sum);
		System.out.println("����90�������ı�����:" + ber + "%");
	}
}
