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
				System.out.println("������������:");
				age = input.nextInt();
				if (age > 0 && age <= 100) {
					people = true;
				}
			}
			stu = stu + age;
		}
		young = stu / 5;
		System.out.println("ƽ��������:" + stu);
		System.out.println("��������:" + young);
	}
}
