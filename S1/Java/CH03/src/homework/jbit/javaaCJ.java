package homework.jbit;

import java.util.Scanner;

public class javaaCJ {
	
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("输入java的成绩分数：");
		int score = input.nextInt();
		if(score>=85){
			System.out.print("优秀");
		}else if(score>=75){
			System.out.println("良好");
		}else if(score>=60){
			System.out.println("及格");
		}else{
			System.out.println("不及格");
		}
	}
}
