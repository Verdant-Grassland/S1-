package cn.jbit;

import java.util.Scanner;

public class TestOdd {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("������һ����Ȼ��:");
		int num = input.nextInt();
		if(num%2 != 0){
			System.out.println(num * 3+1);
		}else if(num%2 == 0){
			System.out.println(num / 2);
		}
	}
}
