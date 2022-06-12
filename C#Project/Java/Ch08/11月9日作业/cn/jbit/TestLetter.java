package cn.jbit;

import java.util.Scanner;

public class TestLetter {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("请输入一个字母:");
		char letter = input.next().charAt(0);
		if(letter >= 97 && letter <= 122){
			System.out.println("输入的是小写字母");
			letter = (char)(letter - 32);
			System.out.println("输入为大写字母是:" + letter);
		}else{
			System.out.println("输入的是大写字母");
		}
	}
}
