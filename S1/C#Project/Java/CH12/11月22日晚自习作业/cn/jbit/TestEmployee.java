package cn.jbit;

import java.util.Scanner;

public class TestEmployee {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Employee work = new Employee();
		System.out.println("��������ְ����:");
		work.empNo = input.nextInt();
		System.out.println("������������:");
		work.name = input.next();
		System.out.println("���������Ա�:");
		work.sex = input.next();
		System.out.println("������������ֵ:");
		work.popularity = input.nextInt();
		work.show();
	}
}
