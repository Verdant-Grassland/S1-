package cn.jbit;

import java.util.Scanner;

public class TestShop {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("���������ѽ��:");
		double money = input.nextInt();
		System.out.println("����鵽���ۿ�:");
		double ze= input.nextInt();
		double zong=money*ze/10;
		System.out.println("�۸���:"+zong );
	}
}