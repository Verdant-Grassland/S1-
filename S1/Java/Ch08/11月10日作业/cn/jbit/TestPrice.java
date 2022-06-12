package cn.jbit;

import java.util.Scanner;

public class TestPrice {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = 0;
		for(int i = 1 ; i <= 5 ; i++){
			System.out.println("输入第" + i + "电脑店的价格:");
			int PhonePrice = input.nextInt();
			num = num + PhonePrice;
		}
		int price = num / 5;
		System.out.println("总价格是:" + num);
		System.out.println("平均价格是:" + price);
	}
}
