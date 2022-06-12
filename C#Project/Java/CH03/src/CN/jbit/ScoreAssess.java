package cn.jbit;

import java.util.Scanner;

public class ScoreAssess {
	
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("输入分数：");
		int score=input.nextInt();
		if(score>=80){
			System.out.println("良好");
		}else if(score>=60){
			System.out.println("中等");
		}else{
			System.out.println("差");
		}
	}
}
