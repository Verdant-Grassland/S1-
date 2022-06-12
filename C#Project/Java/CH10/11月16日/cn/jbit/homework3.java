package cn.jbit;

import java.util.Scanner;

public class homework3 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("请输入一个四位整数:");
		int num = input.nextInt();
		for(int i = 1 ; i <= num ; i++){
		int sumber = 0;
		while(num != 0){
			sumber = sumber + num%10;
			num = num/10;
		}
		System.out.println(sumber);
		}
	}
}
