package cn.jbit;

import java.util.Scanner;

public class TestScore {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in); 
		System.out.println("输入学生成绩:"); 
		double score = input.nextInt();
		double FG = score + (score * 0.2);
		System.out.println("输入加分后成绩:" + FG);
	}
}
