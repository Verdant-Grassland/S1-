package cn.jbit;

import java.util.Scanner;

public class Account {
	Scanner input = new Scanner(System.in);
	public double getMoney(){
		System.out.println("??????????????ѯ:");
		double money = input.nextDouble();
		return money;
    }
}