package cn.jbit;

import java.util.Scanner;

public class TestScore {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int score = 0;
		for (int i = 1 ; i <= 5 ; i++) {
			System.out.println("��" + i + "��ͬѧ");
			int num = input.nextInt();
			score = score + num;
		}
		System.out.println("����:" + score);
		System.out.println("ƽ��:" + (score / 5.0)*100 + "%");
	}
}
