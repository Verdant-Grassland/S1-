package cn.jbit;

import java.util.Scanner;

public class TestCustomer {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Customer card = new Customer();
		System.out.println("输入您的会员积分:");
		card.point = input.nextInt();
		String CardVIP = card.getType();
		System.out.println(CardVIP);
	}
}
