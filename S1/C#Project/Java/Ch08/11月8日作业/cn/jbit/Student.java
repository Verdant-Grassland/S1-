package cn.jbit;

import java.util.Scanner;

public class Student {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入成绩分数:");
		int score = input.nextInt();
		if(score >= 85 && score <= 100){
			System.out.println("A");
		}else if(score >= 74 && score <= 84){
			System.out.println("B");
		}else if(score >= 60 && score <= 69){
			System.out.println("C");
		}else{
			System.out.println("D");
		}
	}
}
