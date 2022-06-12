package cn.jbit;

import java.util.Scanner;

public class TestNuc {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num=(int)(Math.random()*10);
		System.out.println("这个数字是:" + num);
		int ber = 0;
		if (num%2 == 0) {
			System.out.println("这个数字是偶数");
			ber = num * num;
			System.out.println(ber);
		}else{
			System.out.println("这个数字不是偶数");
			ber = num * num * num;
			System.out.println(ber);
		}
	}
}
