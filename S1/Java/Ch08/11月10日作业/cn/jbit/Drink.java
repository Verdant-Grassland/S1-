package cn.jbit;

import java.util.Scanner;

public class Drink {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("ÊäÈëÒûÁÏµÄÀàĞÍ:");
		String drink = input.next();
		switch (drink){
			case "¿§·È":
				System.out.println("¿à");
				break;
			case "Å£ÄÌ":
				System.out.println("Ìğ");
				break;
			case "ÄûÃÊ":
				System.out.println("Ëá");
				break;
		}
	}
}