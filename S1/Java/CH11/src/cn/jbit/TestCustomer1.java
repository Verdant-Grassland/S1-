package cn.jbit;

import java.util.Scanner;

public class TestCustomer1 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Customer1 cust = new Customer1();
		System.out.println("输入积分:");
		cust.point = input.nextInt();
		System.out.println("输入卡类型:");
		cust.Type = input.next();
		cust.showInfo();
		if((cust.Type.equals("金卡") && cust.point > 1000) || (cust.Type.equals("普卡") && cust.point > 5000)){
			System.out.println("获得回归积分500分");
		}else{
			System.out.println("没有任何回归");
		}
	}
}