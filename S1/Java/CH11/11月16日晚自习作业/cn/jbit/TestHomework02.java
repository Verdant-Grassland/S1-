package cn.jbit;

import java.util.Scanner;

public class TestHomework02 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Customer cust = new Customer();
		System.out.println("输入会员积分:");
		cust.point = input.nextInt();
		String Info = cust.show();
		System.out.println(Info);
	}
}
