package cn.jbit;

import java.util.Scanner;

public class Testmoney {

	public static void main(String[] args) {
		System.out.println("����˿����ѽ��:");
		Scanner input = new Scanner(System.in);
		int HG = input.nextInt();
		if(HG*0.8>1000){
			System.out.println("���200Ԫ����ȯһ��");
		}
	}
}
