package cn.jbit;

import java.util.Scanner;

public class Tests03 {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int[] num = new int[5];
		int pingjun = 0;
		for(int i = 0 ; i<num.length ; i++){
			System.out.println("�������" + (i + 1) + "ͬѧ����:");
			num[i] = input.nextInt();
			pingjun = pingjun + num[i];
		}
			double avg = pingjun/num.length;
			System.out.println("ƽ��ֵ:" + avg);
			System.out.println("�ܺ�:" + pingjun);
	}
}
