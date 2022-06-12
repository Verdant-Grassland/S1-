package cn.jbit;

import java.util.Scanner;

public class TestAge {

	public static void main(String[] args) {
		int stu = 0;
		int age = 0;
		int young = 0;
		Scanner input = new Scanner (System.in);
		for (int i = 0; i < 5; i++){
			boolean people = false;
			while(people == false){
				System.out.println("输入您的年龄:");
				age = input.nextInt();
				if (age > 0 && age <= 100) {
					people = true;
				}
			}
			stu = stu + age;
		}
		young = stu / 5;
		System.out.println("平均年龄是:" + stu);
		System.out.println("总年龄是:" + young);
	}
}
