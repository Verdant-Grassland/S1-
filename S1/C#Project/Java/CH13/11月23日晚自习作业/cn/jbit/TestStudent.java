package cn.jbit;

import java.util.Scanner;

public class TestStudent {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Student num = new Student();
		System.out.println("�������ĳɼ�:");
		int sum = input.nextInt();
		String grade = num.getGrade(sum);
		System.out.println(grade);
	}
}