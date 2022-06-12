package cn.jbit;

import java.util.Scanner;

public class TestBank {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("=================欢迎使用MyBank银行管理系统===============");
		System.out.println("1.显示所有用户");
		System.out.println("2.存款");
		System.out.println("3.取款");
		System.out.println("4.修改密码");
		System.out.println("5.查询余额");
		System.out.println("6.转账");
		System.out.println("7.退出系统");
		System.out.println("====================================================");
		System.out.println("请选择数字:");
		int num = input.nextInt();
		boolean flag;
		do{
		flag = false;
			switch(num){
				case 1:
					System.out.println("显示所有用户");
					break;
				case 2:
					System.out.println("存款");
					break;
				case 3:
					System.out.println("取款");
					break;
				case 4:
					System.out.println("修改密码");
					break;
				case 5:
					System.out.println("查询余额");
					break;
				case 6:
					System.out.println("执行转账");
					break;
				case 7:
					System.out.println("退出系统");
					break;
				default:
					System.out.println("输入数字错误，请你重新选择数字:");
					num = input.nextInt();  
					flag = true;
			}
		}while(flag);
	}
}
