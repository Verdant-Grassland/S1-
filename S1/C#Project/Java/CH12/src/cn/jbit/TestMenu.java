package cn.jbit;

import java.util.Scanner;

public class TestMenu {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Menu menu = new Menu();
		Manager manger = new Manager();
		manger.username = "admin";
		manger.password = "0000";
		menu.showLoginMenu();
		boolean flag;
		do{
	 		flag = false;
	 		int num = input.nextInt();
	 		switch(num) {
	 		case 1:
	 			System.out.println("输入用户名:");
	 			String name = input.next();
	 			System.out.println("输入密码:");
	 			String pwd = input.next();
	 			if(name.equals(manger.username) && pwd.equals(manger.password)){
	 				System.out.println("登录成功，用户名:" + name);
	 				menu.showMainMenu();
	 				break;
	 			}else{
	 				System.out.println("您没有权限登录系统，用户名和密码错误！");
	 				menu.showLoginMenu();
	 			}
	 			break;
	 		case 2:
	 			System.out.println("退出");
	 			flag = false;
	 			break;
	 		}
	 	}while(flag);
	}
}
