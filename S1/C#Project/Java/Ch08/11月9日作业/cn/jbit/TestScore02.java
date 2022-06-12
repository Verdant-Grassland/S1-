package cn.jbit;

import java.util.Scanner;

public class TestScore02 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入您的考试成绩:");
		int score = input.nextInt();
		if(score >= 90 && score <= 100){
			System.out.println("优秀");
		}else if(score >= 80 && score <= 89){
			System.out.println("良好");
		}else if(score >= 70 && score <= 79){
			System.out.println("中等");
		}else if(score >= 60 && score <= 69){
			System.out.println("及格");
		}else{
			System.out.println("不及格");
		}
	}
}
