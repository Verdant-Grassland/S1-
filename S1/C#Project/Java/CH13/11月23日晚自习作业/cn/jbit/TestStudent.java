package cn.jbit;

import java.util.Scanner;

public class TestStudent {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Student num = new Student();
		System.out.println("ÊäÈëÄúµÄ³É¼¨:");
		int sum = input.nextInt();
		String grade = num.getGrade(sum);
		System.out.println(grade);
	}
}