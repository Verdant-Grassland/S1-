package cn.jbit;

import java.util.Scanner;

public class TestLumber {

	/**
	 * 输入一个正整数，将其逆序输出     如：123输出321
	 */
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入需要逆序的数字:");
		int num = input.nextInt();
		while(num != 0){
			System.out.print(num % 10);
			num = num / 10;
		}
	}
}
