package cn.jbit;

import java.util.Scanner;

public class TestStudent {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Student student = new Student();
		System.out.println("��������ѧ��:");
		student.stuNo = input.nextInt();
		System.out.println("������������:");
		student.name = input.next();
		System.out.println("������������:");
		student.age = input.nextInt();
		System.out.println("���������Ա�:");
		student.sex = input.next();
		String Schools = student.getGrade();
		System.out.println(Schools);
	}
}
