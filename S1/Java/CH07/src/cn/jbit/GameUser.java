package cn.jbit;

import java.util.Scanner;

public class GameUser {

	public static void main(String[] args) {
		System.out.println("青鸟迷你游戏平台 > 添加用户信息\n");
		int custNo = 0;
		int age;
		int points = 0;
		System.out.println("请输入要录入用户的数量:");
		Scanner input = new Scanner(System.in);
		int count = input.nextInt();
		for (int i = 0 ; i < count ; i++) {
			System.out.println("请输入用户编号(<4位整数:>)");
			custNo = input.nextInt();
			System.out.println("请输入用户年龄:");
			age = input.nextInt();
			if (age < 10 || age > 100) {
				System.out.println("很抱歉，您的年龄不适宜玩游戏");
				System.out.println("录入信息失败\n");
				continue;
			}
			System.out.println("请输入会员积分:");
			points = input.nextInt();
			System.out.println("您录入的会员信息是:");
			System.out.println("用户编号:" + custNo + "\t年龄:" + age + "\t积分:" + points + "\n");
		}
	}
}
