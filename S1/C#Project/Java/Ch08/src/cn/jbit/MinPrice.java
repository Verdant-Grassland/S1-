package cn.jbit;

import java.util.Scanner;

public class MinPrice {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("请输入4家店的价格");
		int[] num = new int[5];
		for(int i = 0 ; i<num.length ; i++){
			System.out.println("第" + (i + 1) + "家店的价格:");
			num[i] = input.nextInt();
		}
		int min = num[0];
		for(int i = 1 ; i<num.length ; i++){
			if(num[i] < min){
				min = num[i];
			}
		}
		System.out.println("最低价格是:" + min);
	}
}
