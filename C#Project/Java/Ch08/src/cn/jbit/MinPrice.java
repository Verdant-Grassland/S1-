package cn.jbit;

import java.util.Scanner;

public class MinPrice {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("������4�ҵ�ļ۸�");
		int[] num = new int[5];
		for(int i = 0 ; i<num.length ; i++){
			System.out.println("��" + (i + 1) + "�ҵ�ļ۸�:");
			num[i] = input.nextInt();
		}
		int min = num[0];
		for(int i = 1 ; i<num.length ; i++){
			if(num[i] < min){
				min = num[i];
			}
		}
		System.out.println("��ͼ۸���:" + min);
	}
}