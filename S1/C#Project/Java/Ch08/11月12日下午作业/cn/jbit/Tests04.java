package cn.jbit;

import java.util.Scanner;

public class Tests04 {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int[] num = new int[5];
		int score = 0;
		int binglie = 0;
		for(int i = 0 ; i<num.length ; i++){
			System.out.println("�������" + (i + 1) + "��ͬѧ�ĳɼ�:");
			num[i] = input.nextInt();
			score = score + num[i];
			if(num[i] > 60){
				binglie++;
			}
		}
		double binglie1 = (binglie/5.0) * 100;
		System.out.println("�ܺ�:" + score);
		System.out.println("�ܷ���:" + binglie1 + "%");
	}
}
