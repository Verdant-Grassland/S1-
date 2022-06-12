package cn.jbit;

import java.util.Scanner;

public class TestDrink {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Drink drink = new Drink();
		System.out.println("ÊäÈëÒûÁÏÃû³Æ:");
		drink.DrinkName = input.next();
		String name = drink.getInfo();
		System.out.println(name);
	}
}
