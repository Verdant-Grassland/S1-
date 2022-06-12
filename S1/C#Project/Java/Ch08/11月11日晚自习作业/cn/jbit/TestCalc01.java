package cn.jbit;

import java.util.Scanner;

public class TestCalc01 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("=================欢迎使用用户管理系统=================");
		System.out.println("\t\t1.增加用户");
		System.out.println("\t\t2.查看所有用户信息");
		System.out.println("\t\t3.修改用户名");
		System.out.println("\t\t4.按用户名查询个人信息");
		System.out.println("\t\t5.退出");
		System.out.println("================================================");
		System.out.println("请选择数字:");
		int choice = input.nextInt();
		boolean num;
		do{
			num = false;
			switch(choice){
			case 1:
				System.out.println("进入您的增加用户");
				break;
			case 2:
				System.out.println("进入查看所有用户信息");
				break;
			case 3:
				System.out.println("进入修改用户名");
				break;
			case 4:
				System.out.println("进入按用户名查询个人信息");
				break;
			case 5:
				System.out.println("退出登录");
				break;
			default:
				num = false;
				System.out.println("选择数字错误，请重新输入数字:");
				choice = input.nextInt();
				break;
			}
		}while(num);
	}
}
