package cn.jbit;

import java.util.Scanner;

public class homework4 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入互换前手中的纸牌:");
		System.out.println("左手中的纸牌:");
		int lefthight = input.nextInt();
		System.out.println("右手中的纸牌:");
		int righthight = input.nextInt();
		System.out.println("\n输入互换后手中的纸牌:");
		System.out.println("左手中的纸牌:" + righthight);
		System.out.println("右手中的纸牌:" + lefthight);
	}
}
