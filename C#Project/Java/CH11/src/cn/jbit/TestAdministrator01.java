package cn.jbit;

import java.util.Scanner;

public class TestAdministrator01 {

	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Administrator01 admin = new Administrator01();
		admin.name = "admin";
		admin.password = "123456";
		System.out.println("输入用户名:");
		String uname = input.next();
		System.out.println("输入密码:");
		String upwd = input.next();
		boolean flag;
		do{
			flag = false;
			if(admin.name.equals(uname) && admin.password.endsWith(upwd)){
				System.out.println("输入新密码:");
				admin.password = input.next();
				System.out.println("修改成功，新密码的值是:" + admin.password);
			}else{
				flag = true;
				System.out.println("用户名和密码错误!");
				System.out.println("请重新输入用户名:");
				uname = input.next();
				System.out.println("请重新输入密码:");
				upwd = input.next();
			}
		}while(flag);
//		admin.name = "admin";
//		admin.password = "798254";
//		admin.show();
//
//		Administrator01 admin1 = new Administrator01();
//		admin1.name = "halen";
//		admin1.password = "739641";
//		admin1.show();
	}
}
