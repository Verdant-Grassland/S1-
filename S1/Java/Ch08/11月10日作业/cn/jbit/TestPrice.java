package cn.jbit;

import java.util.Scanner;

public class TestPrice {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = 0;
		for(int i = 1 ; i <= 5 ; i++){
			System.out.println("�����" + i + "���Ե�ļ۸�:");
			int PhonePrice = input.nextInt();
			num = num + PhonePrice;
		}
		int price = num / 5;
		System.out.println("�ܼ۸���:" + num);
		System.out.println("ƽ���۸���:" + price);
	}
}
