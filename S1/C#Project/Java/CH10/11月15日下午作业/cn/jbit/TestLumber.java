package cn.jbit;

import java.util.Scanner;

public class TestLumber {

	/**
	 * ����һ���������������������     �磺123���321
	 */
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("������Ҫ���������:");
		int num = input.nextInt();
		while(num != 0){
			System.out.print(num % 10);
			num = num / 10;
		}
	}
}
