package cn.jbit;

import java.util.Scanner;

public class TestCustomer1 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Customer1 cust = new Customer1();
		System.out.println("�������:");
		cust.point = input.nextInt();
		System.out.println("���뿨����:");
		cust.Type = input.next();
		cust.showInfo();
		if((cust.Type.equals("��") && cust.point > 1000) || (cust.Type.equals("�տ�") && cust.point > 5000)){
			System.out.println("��ûع����500��");
		}else{
			System.out.println("û���κλع�");
		}
	}
}