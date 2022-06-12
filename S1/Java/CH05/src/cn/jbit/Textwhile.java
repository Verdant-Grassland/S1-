package cn.jbit;

import java.util.Scanner;

public class Textwhile {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.print("合格了吗?(y/n)：");
		String answer = input.next();
		while(!"y".equals(answer)) {
			System.out.println("上午阅读教材！");
			System.out.println("下午上机编程！\n");
			System.out.print("合格了吗?(y/n)：");
			answer = input.next();
		}
		System.out.println("完成学习任务！");
	}
}
