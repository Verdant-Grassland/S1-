package cn.jbit;

import java.util.Scanner;

public class Testhomework04 {
	
	/**
	 * ���Ĺ���Ա����
	 */

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Administrator admin = new Administrator();
		admin.name = "admin1";
		admin.password = "111111";
		System.out.println("�������û���:");
		String nameInput = input.next();
		System.out.println("����������:");
		String pwd = input.next();
		if(admin.name.equals(nameInput) && admin.password.equals(pwd)){
			System.out.println("\n������������:");
			admin.password = input.next();
			System.out.println("�޸�����ɹ�������������Ϊ:" + admin.password);
		}else{
			System.out.println("�û��������벻ƥ��!��û��Ȩ�޸��¹���Ա��Ϣ��");
		}
	}
}
