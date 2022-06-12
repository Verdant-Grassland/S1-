package cn.jbit;

import java.util.Scanner;

public class TestGame {

	public static void main(String[] args) {
		System.out.println("欢迎进入青鸟游戏迷你戏平台");
		System.out.println("请选择您喜爱的游戏:\n");
		System.out.println("***************************************************");
		System.out.println("1.斗地主");
		System.out.println("2.斗牛");
		System.out.println("3.泡泡龙");
		System.out.println("4.连连看");
		System.out.println("***************************************************");
		int choice;	
		boolean isRight;
		System.out.print("请选择，输入数字：");
		Scanner input = new Scanner(System.in);
		do{
			isRight = true;
			choice = input.nextInt();
			switch (choice) {
			case 1:
				System.out.println("您已进入斗地主房间");
				break;
			case 2:
				System.out.println("您已进入斗牛房间");
				break;
			case 3:
				System.out.println("您已进入泡泡龙房间");
				break;
			case 4:
				System.out.println("您已进入连连看房间");
				break;
			default:
				System.out.print("输入错误，请重新输入数字：");
				isRight = false;
				break;
			}
		}while(!isRight);
	}
}
