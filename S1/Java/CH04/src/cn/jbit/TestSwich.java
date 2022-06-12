package cn.jbit;

import java.util.Scanner;

public class TestSwich {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入名次：");
		int mingCi=input.nextInt();
		switch(mingCi){
		case 1:
			System.out.println("麻省理工大学组织的1个月夏令营");
			break;
		case 2:
			System.out.println("奖励惠普笔记本电脑一部");
			break;
		case 3:
			System.out.println("奖励移动硬盘一个");
			break;
		default:
			System.out.println("没有任何奖励");
			break;
		}
	}

}
