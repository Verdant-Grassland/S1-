package cn.jbit;

import java.util.Scanner;

public class Discount02 {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入会员本月的消费记录");
		double[] num = new double[5];
		double money = 0;
		for(int i = 0 ; i<num.length ; i++){
			System.out.println("请输入第" + (i + 1) + "笔购物金额:");
			num[i] = input.nextDouble();
			money = money + num[i];
		}
		System.out.println("序号" + "\t" + "金额(元)");
		for(int i = 0 ; i<num.length ; i++){
			System.out.println((i + 1) + "\t" + num[i]);
		}
		System.out.println("总金额" + "\t" + money);
	}
}
