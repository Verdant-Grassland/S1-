package cn.jbit;

import java.util.Scanner;

public class LuckBuy2 {

	/**
	 * 幸运大奖（未完全成）
	 */
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String answer = "y";
		while(answer.equals("y")){
		System.out.println("*****欢迎进入奖客富翁系统*****");
		System.out.println("\t1.注册");
		System.out.println("\t2.登录");
		System.out.println("\t3.抽奖");
		System.out.println("***********************");
		System.out.println("请选择菜单:");
		int choice = input.nextInt();
		switch(choice){
		case 1:
			System.out.println("[奖客富翁系统 > 注册]");
			break;
		case 2:
			System.out.println("[奖客富翁系统 > 登录]");
			break;
		case 3:
			System.out.println("[奖客富翁系统 > 抽奖]");
			break;
		default:
			System.out.println("[您的输入有误!]");
			break;
		}
		System.out.println("继续吗？(y/n):");
		answer = input.next();
		}
		System.out.println("系统退出，谢谢使用！");
	}
}

