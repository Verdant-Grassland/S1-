package cn.jbit;

import java.util.Scanner;

public class TestAge01 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("������������:");
		int age = input.nextInt();
		if (age != 18) {
			age = 81;
			System.out.println("���䲻��18���޸ĺ�age=" + age);
		}else{
			System.out.println("������18");
		}
	}
}
