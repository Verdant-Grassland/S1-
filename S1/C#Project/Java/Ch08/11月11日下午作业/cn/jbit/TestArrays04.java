package cn.jbit;

import java.util.Scanner;

public class TestArrays04 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String[]name = new String[5];
		for(int i = 0 ; i<name.length ; i++){
			System.out.println("输入第" + (i + 1) + "个学生的姓名:");
			name[i] = input.next();
		}
		System.out.println("同学的名字是:");
		for(int i = 0 ; i<name.length ; i++){
			System.out.print(name[i] + "\t");
		}
	}
}
