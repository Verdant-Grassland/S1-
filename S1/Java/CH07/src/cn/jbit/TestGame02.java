package cn.jbit;

import java.util.Scanner;

public class TestGame02 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int i = 1;
		int count = 0;
		int score = 0;
		String answer;
		System.out.println("青鸟迷你游戏平台 > 游戏晋级\n");
		 do{
			System.out.print("您正在玩第" + i + "局,成绩为： ");
			score = input.nextInt();
			if (score >= 80) {
				count++;
			}
			i++;
			if (i > 5) {
				System.out.print("游戏结束");
			} else {
				System.out.print("继续玩下一局吗？(yes/no) ");
				answer = input.next();
				if (answer.equals("no")) {
					System.out.print("您已经中途退出游戏。");
					break;
				} else {
					System.out.println("进入下一局");
				}
			}

		}while (i <= 5);

		double rate = count / 5.0;
		if (i > 5) {
			if (rate > 0.8) {
				System.out.println("\n晋级为一级");
			} else if (rate > 0.6) {
				System.out.println("\n晋级为二级");
			} else {
				System.out.println("\n不能晋级");
			}
		} else {
			System.out.println("\n您不足5局");
		}
	}
}
