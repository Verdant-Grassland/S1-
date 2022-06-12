package cn.jbit;

import java.util.Scanner;

public class user {
	
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("输入4位的会员号：");
		int num=input.nextInt();
		if(num>=1000 && num<=9999){
			System.out.println("输入会员的生日：");
			String birthday=input.next();
			System.out.println("输入会员的积分：");
			int point=input.nextInt();
			System.out.println("\n已录入的会员信息是：");
			System.out.println(num+"\t"+birthday+"\t"+point);
		}else{
			System.out.println("输入会员卡号不正确，请输入4位的会员卡号");
		}
	}
}
