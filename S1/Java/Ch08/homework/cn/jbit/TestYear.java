package cn.jbit;

import java.util.Scanner;

public class TestYear {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入一个年份:");
		int month = input.nextInt();
		if (month%4==0 && month%100!=0 || month%400==0){
			System.out.println("闰年");
		}
	}
}
