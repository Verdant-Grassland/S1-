package cn.jbit;

import java.util.Arrays;
import java.util.Scanner;

public class TestWork2 {

	public static void main(String[] args) {
		int[] score = new int[5];
		Scanner input = new Scanner(System.in);
		for(int i = 0 ; i<score.length ; i++){
			System.out.println("�������" + (i + 1) + "����ί�Ĵ��:");
			score[i] = input.nextInt();
		}
		Arrays.sort(score);
		int sum = score[1] + score[2] + score[3];
		System.out.println("ѡ�����ĵ÷�:" + sum);
	}
}
