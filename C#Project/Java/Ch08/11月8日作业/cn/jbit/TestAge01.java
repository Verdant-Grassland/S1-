package cn.jbit;

import java.util.Scanner;

public class TestAge01 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入您的年龄:");
		int age = input.nextInt();
		if (age != 18) {
			age = 81;
			System.out.println("年龄不是18，修改后age=" + age);
		}else{
			System.out.println("年龄是18");
		}
	}
}
