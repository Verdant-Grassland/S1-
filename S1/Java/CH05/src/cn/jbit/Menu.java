package cn.jbit;

import java.util.Scanner;

public class Menu {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		boolean flag;
		System.out.println("*******************************");
		System.out.println("\t1.客 户 信 息 管 理");
		System.out.println("\t2.购 物 结 算");
		System.out.println("\t3.真 情 回 馈");
		System.out.println("\t4.注 销");
		System.out.println("*******************************\n");
		System.out.print("请选择，输入数字：");
		int num = input.nextInt();
		do{
			flag = false;
			switch(num){
			case 1:
				System.out.println("执行客户信息管理");
				break;
			case 2:
				System.out.println("执行购物结算");
				break;
			case 3:
				System.out.println("执行真情回馈");
				break;
			case 4:
				System.out.println("执行注销");
				break;
			default:
				System.out.print("输入错误，请重新输入数字：");
				num = input.nextInt();
				flag = true;
				break;
			}
		}while(flag);
	}
}