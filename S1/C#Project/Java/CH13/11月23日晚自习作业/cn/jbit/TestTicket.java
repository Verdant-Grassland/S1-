package cn.jbit;

import java.util.Scanner;

public class TestTicket {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Ticket tick = new Ticket();
		System.out.println("�������Ļ�Ʊ��Ǯ��:");
		int money = input.nextInt();
		String trip = tick.sale(money);
		System.out.println(trip);
	}
}
