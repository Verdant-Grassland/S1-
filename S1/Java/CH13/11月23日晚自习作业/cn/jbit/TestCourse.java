package cn.jbit;

import java.util.Scanner;

public class TestCourse {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Course sum = new Course();
		System.out.println("��������java�ɼ�:");
		int java = input.nextInt();
		System.out.println("��������html�ɼ�:");
		int html = input.nextInt();
		System.out.println("��������sql�ɼ�:");
		int sql = input.nextInt();
		int num = sum.calc(java, html, sql);
		System.out.println("�����ܷ����ɼ���:" + num);
	}
}
