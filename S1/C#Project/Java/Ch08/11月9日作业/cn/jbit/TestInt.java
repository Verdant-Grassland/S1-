package cn.jbit;

import java.util.Scanner;

public class TestInt {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("请输入一个整数:");
		int num = input.nextInt();
		int qianwei = num/1000;
		int baiwei = num/100%10;
		int shiwei = num/10%10;
		int gewei = num%10;
		int sum1 = qianwei;	
			qianwei = gewei;
			gewei = sum1;
		int sum2 = baiwei;
			baiwei = shiwei;
			shiwei = sum2;
			System.out.println("是:" + qianwei + baiwei + shiwei + gewei);
	}
}
