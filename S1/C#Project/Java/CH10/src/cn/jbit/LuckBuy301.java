package cn.jbit;

import java.util.Scanner;

public class LuckBuy301 {

	/**
	 * 幸运大奖（未完全成）
	 */
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String answer = "y";
		int max = 9999;
		int min = 1000;
		while(answer.equals("y")){
		System.out.println("*****欢迎进入奖客富翁系统*****");
		System.out.println("\t1.注册");
		System.out.println("\t2.登录");
		System.out.println("\t3.抽奖");
		System.out.println("***********************");
		System.out.println("请选择菜单:");
		int choice = input.nextInt();
		String userName = "";
		String password = "";
		int cardNumber = (int)(Math.random()*(max-min)) +min;
		boolean isRegister = false;
		switch(choice){
		case 1:
			System.out.println("[奖客富翁系统 > 注册]");
			System.out.println("请镇写个人注册信息:");
			System.out.println("用户名:");
			userName = input.next();
			System.out.print("密码:");
			password = input.next();
			System.out.println("\n注册成功，请记好您的会员卡号");
			System.out.println("用户名\t密码\t会员卡号");
			System.out.println(userName + "\t" + password + "\t" + cardNumber);
			isRegister = true;
			break;
		case 2:
			System.out.println("[奖客富翁系统 > 登录]");
			if(isRegister){
				
			}else{
				System.out.println("您还没有注册呢？不能登录");
			}
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

