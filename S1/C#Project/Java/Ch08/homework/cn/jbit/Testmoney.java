package cn.jbit;

import java.util.Scanner;

public class Testmoney {

	public static void main(String[] args) {
		System.out.println("输入顾客消费金额:");
		Scanner input = new Scanner(System.in);
		int HG = input.nextInt();
		if(HG*0.8>1000){
			System.out.println("获得200元代金券一张");
		}
	}
}
