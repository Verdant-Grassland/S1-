package cn.jbit;

import java.util.Scanner;

public class TestWuMingFen {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		WuMingFen wmf = new WuMingFen();
		System.out.println("输入面码:");
		wmf.theMa = input.next();
		System.out.println("输入粉的分量:");
		wmf.quantity = input.nextInt();
		System.out.println("输入您的是否带汤:");
		wmf.likeSoup = input.nextBoolean();
		wmf.display();
	}
}
