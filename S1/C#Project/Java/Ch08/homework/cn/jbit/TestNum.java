package cn.jbit;

import java.util.Scanner;

public class TestNum {

	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("�����һ����:");
		int num1 = input.nextInt();
		System.out.println("����ڶ�����:");
		int num2 = input.nextInt();
		System.out.println("�����������:");
		int num3 = input.nextInt();
		int sum = num1 + num2 + num3;
		for(int i = 1 ; i <= 1000 ; i++){
			if(sum == i){
				System.out.println(i);
			}
		}
	}
}