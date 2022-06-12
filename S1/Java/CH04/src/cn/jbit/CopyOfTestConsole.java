package cn.jbit;

import java.util.Scanner;

public class CopyOfTestConsole {

	public static void main(String[] args) {
		System.out.println("\t\t欢迎使用我行我素购物管理系统\n");
		System.out.println("\t\t\t1.登录系统\n");
		System.out.println("\t\t\t2.退出\n");
		System.out.println("* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *\n");
		System.out.println("请选择，输入数字：");
		Scanner input = new Scanner(System.in);
		if(input.hasNext()==true){
			int num = input.nextInt();
			switch (num){
				case 1:
					System.out.println("1.客户信息管理");
					System.out.println("2.购物结算");
					System.out.println("3.真情回馈");
					System.out.println("4.注销");
					break;
				case 2:
					System.out.println("退出系统，谢谢您的使用！");
				    break;
				  default:
				    System.out.println("输入错误。");
				    break;
				}
			}else{
				System.out.println("请输入正确的数字！");
			}
		}
	}
