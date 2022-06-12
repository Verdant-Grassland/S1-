package cn.jbit;

import java.util.Scanner;

public class Tests02 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("*******************欢迎青鸟库存管理系统*******************");
		System.out.println("1.增加货物类型");
		System.out.println("2.查询所用货物类型");
		System.out.println("3.商品入库");
		System.out.println("4.商品出库");
		System.out.println("5.退出系统");
		System.out.println("****************************************************");
		System.out.println("请选择数字:");
		int num = input.nextInt();
		boolean shopping;
		do{
			shopping = false;
			switch(num){
			case 1:
				System.out.println("进入增加货物类型");
				break;
			case 2:
				System.out.println("进入查询所有货物类型");
				break;
			case 3:
				System.out.println("进入商品入库");
				break;
			case 4:
				System.out.println("进入商品出库");
				break;
			case 5:
				System.out.println("退出系统");
				break;
			default:
				System.out.println("数字错误，请重新输入选择数字:");
				num = input.nextInt();
				shopping = true;
			}
		}while(shopping);
	}
}
