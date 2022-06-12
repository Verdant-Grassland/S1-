package cn.jbit;

import java.util.Scanner;

public class Tests03 {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int[] num = new int[5];
		int pingjun = 0;
		for(int i = 0 ; i<num.length ; i++){
			System.out.println("请输入第" + (i + 1) + "同学年龄:");
			num[i] = input.nextInt();
			pingjun = pingjun + num[i];
		}
			double avg = pingjun/num.length;
			System.out.println("平均值:" + avg);
			System.out.println("总和:" + pingjun);
	}
}
