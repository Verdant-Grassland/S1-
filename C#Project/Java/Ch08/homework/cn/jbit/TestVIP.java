package cn.jbit;

import java.util.Scanner;

public class TestVIP {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("���빺����:");
		double money = input.nextDouble();
		System.out.println("�����̳���Ա����:");
		int score = input.nextInt();
		if(score > 8000){
			System.out.println("Ӧ�����Ϊ:" + (money * 0.7));
		}else if(score < 8000){
			System.out.println("Ӧ�����Ϊ:" + (money * 0.75));
		}else if(score < 4000){
			System.out.println("Ӧ�����Ϊ:" + (money * 0.8));
		}else if(score < 2000){
			System.out.println("Ӧ�����Ϊ:" + (money * 0.9));
		}
	}
}
