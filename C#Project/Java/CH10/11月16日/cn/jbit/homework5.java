package cn.jbit;

import java.util.Scanner;

public class homework5 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入银行简称:");
		String bank = input.next();
		if (bank.equals("ICBC")){
			System.out.println("中国工商银行");
		}else if (bank.equals("CBC")){
			System.out.println("中国建设银行");
		}else if (bank.equals("ABC")){
			System.out.println("中国农业银行");
		}
	}
}
