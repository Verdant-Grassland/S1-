package cn.jbit;

import java.util.Scanner;

public class TestShop {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("请输入消费金额:");
		double money = input.nextInt();
		System.out.println("输入抽到的折扣:");
		double ze= input.nextInt();
		double zong=money*ze/10;
		System.out.println("价格是:"+zong );
	}
}
