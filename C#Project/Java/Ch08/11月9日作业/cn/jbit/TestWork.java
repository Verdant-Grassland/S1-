package cn.jbit;

import java.util.Scanner;

public class TestWork {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入您的上班时间:");
		int time = input.nextInt();
		System.out.println("输入您的工资:");
		int salary = input.nextInt();
		if(time <= 160){
			System.out.println("工作时间是:" + time + "，工资为:" + time * salary);
		}else if(time > 160){
			System.out.println("工作时间是:" + time + "，工资为:" + (160 * salary + (time - 160) * salary * 1.5));
		}
	}
}
