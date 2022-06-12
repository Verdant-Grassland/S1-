package cn.jbit;

import java.util.Scanner;

public class Guess {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入一个数:");
		int num1 = input.nextInt();
		int num2 = (int)(Math.random()*10);
		if(num1 > num2){
			System.out.println("猜错了，比这个数小");
		}else if(num1 < num2){
			System.out.println("猜错了，比这个数大");
		}else if(num1 == num2){
			System.out.println("恭喜你，答对了");
		}
	}
}
