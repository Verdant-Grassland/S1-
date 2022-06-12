package cn.jbit;

import java.util.Scanner;

public class Tests04 {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int[] num = new int[5];
		int score = 0;
		int binglie = 0;
		for(int i = 0 ; i<num.length ; i++){
			System.out.println("请输入第" + (i + 1) + "个同学的成绩:");
			num[i] = input.nextInt();
			score = score + num[i];
			if(num[i] > 60){
				binglie++;
			}
		}
		double binglie1 = (binglie/5.0) * 100;
		System.out.println("总和:" + score);
		System.out.println("总分数:" + binglie1 + "%");
	}
}
