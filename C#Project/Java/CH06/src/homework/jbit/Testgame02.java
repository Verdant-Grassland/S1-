package homework.jbit;

import java.util.Scanner;

public class Testgame02 {
	
	public static void main(String[] args) {
		boolean flag;
		System.out.println("欢迎进入青鸟游戏迷你戏平台");
		System.out.println("请选择您喜爱的游戏:");
		System.out.println("***************************************************");
		System.out.println("1.斗地主");
		System.out.println("2.斗牛");
		System.out.println("3.泡泡龙");
		System.out.println("4.连连看");
		System.out.println("***************************************************");
		Scanner input = new Scanner(System.in);
		System.out.println("请选择，输入数字:");
		int num = input.nextInt();
		do {
			flag = false;
			switch(num){
			case 1:
				System.out.println("你已经进入斗地主房间");
				break;
			case 2:
				System.out.println("你已经进入斗牛房间");
				break;
			case 3:
				System.out.println("你已经进入泡泡龙房间");
				break;
			case 4:
				System.out.println("你已经进入连连看房间");
				break;
			default:
				System.out.print("输入错误，请重新输入数字：");
				num = input.nextInt();
				flag = true;
				break;
			}
		}while(flag);
	}
}
