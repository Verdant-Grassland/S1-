package cn.jbit;

import java.util.Scanner;

public class TestName {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[] num = new String[5];
		for(int i = 0 ; i < num.length ; i++){
			System.out.println("�����" + (i + 1) + "��������:");
			num[i] = input.next();
		}
		for(int i = 0 ; i <= num.length ; i++){
			System.out.println(num[i] + "\t");
		}
		
	}
}