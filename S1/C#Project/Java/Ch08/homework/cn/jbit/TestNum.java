package cn.jbit;

import java.util.Scanner;

public class TestNum {

	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("输入第一个数:");
		int num1 = input.nextInt();
		System.out.println("输入第二个数:");
		int num2 = input.nextInt();
		System.out.println("输入第三个数:");
		int num3 = input.nextInt();
		int sum = num1 + num2 + num3;
		for(int i = 1 ; i <= 1000 ; i++){
			if(sum == i){
				System.out.println(i);
			}
		}
	}
}
