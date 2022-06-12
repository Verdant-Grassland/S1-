package cn.jbit;

import java.util.Scanner;

public class TestTicket {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Ticket tick = new Ticket();
		System.out.println("输入您的火车票的钱数:");
		int money = input.nextInt();
		String trip = tick.sale(money);
		System.out.println(trip);
	}
}
