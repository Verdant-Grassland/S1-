package cn.jbit;

import java.util.Arrays;

import java.util.Scanner;

public class TesstArrays02 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int[] num = new int[5];
		for(int i = 0 ; i<num.length ; i++){
			System.out.println("输入第" + (i + 1) + "个同学的分数:");
			num[i]= input.nextInt();
		}
		System.out.print("从高到低排序");
		Arrays.sort(num);
		for(int i = num.length-1 ; i >= 0 ; i--){
			System.out.print(num[i] + "\t");
		}
	}
}
