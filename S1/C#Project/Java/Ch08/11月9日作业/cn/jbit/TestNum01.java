package cn.jbit;

import java.util.Scanner;

public class TestNum01 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("请输入一个数字:");
		int sum = 1;
		int num = input.nextInt();
		for(int i = 1 ; i <= num ; i++){
			sum = sum * 1;
		}
		System.out.println("阶乘为:" + sum);
	}
}
