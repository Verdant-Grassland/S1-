package cn.jbit;

import java.util.Scanner;

public class TestAdministrator01 {

	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Administrator01 admin = new Administrator01();
		admin.name = "admin";
		admin.password = "123456";
		System.out.println("�����û���:");
		String uname = input.next();
		System.out.println("��������:");
		String upwd = input.next();
		boolean flag;
		do{
			flag = false;
			if(admin.name.equals(uname) && admin.password.endsWith(upwd)){
				System.out.println("����������:");
				admin.password = input.next();
				System.out.println("�޸ĳɹ����������ֵ��:" + admin.password);
			}else{
				flag = true;
				System.out.println("�û������������!");
				System.out.println("�����������û���:");
				uname = input.next();
				System.out.println("��������������:");
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
