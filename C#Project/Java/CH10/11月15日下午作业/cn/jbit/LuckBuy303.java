package cn.jbit;

import java.util.Scanner;

public class LuckBuy303 {

	/**
	 * 幸运大奖（已完全成）
	 */
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		String answer = "y";
		String userName = "";
		String password = "";
		int max = 9999;
		int min = 1000;
		boolean isRegister = false;
		boolean isLogin = false;
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
			System.out.println("请镇写个人注册信息:");
			System.out.println("用户名:");
			userName = input.next();
			System.out.print("密码:");
			password = input.next();
			int cardNumber = (int)(Math.random()*(max-min)) +min;
			System.out.println("\n注册成功，请记好您的会员卡号");
			System.out.println("用户名\t密码\t会员卡号");
			System.out.println(userName + "\t" + password + "\t" + cardNumber);
			isRegister = true;
			break;
		case 2:
			System.out.println("[奖客富翁系统 > 登录]");
			if(isRegister){
				for(int i = 1 ; i <= 3 ; i++){
					System.out.println("请输入用户名:");
					String inputName = input.next();
					System.out.println("请输入密码:");
					String inputPassWord = input.next();
					if(userName.equals(inputName) && password.equals(inputPassWord)){
						System.out.println("\n欢迎您:" + userName);
						isLogin = true;
						break;
					}else{
						System.out.println("用户名或密码错误，还有" + (3 - i) + "次机会!");
					}
					if(i == 3){
						System.out.println("三次用户名及密码均不对");
					}  
				}
			}else{
				System.out.println("您还没有注册呢？不能登录");
			}
			break;
		case 3:
			System.out.println("[奖客富翁系统 > 抽奖]");
			if (isLogin){
				System.out.println("输入会员卡号:");
				int num = input.nextInt();
				int[] goodNum = new int[5];
				boolean flag = false;
				System.out.println("\n本日的幸运数字是:");
				 for(int i = 0; i < goodNum.length; i++){
				    goodNum[i] = (int)(Math.random()*(max-min))+min;
				    System.out.print(goodNum[i] + "\t");
				    if(goodNum[i] == num){
				    	System.out.println("\n恭喜你成为了幸运的会员!");
						flag = true;
				    	break;
				    }
				 }
				 if(!flag){
					 System.out.println("\n抱歉! 您不是本日的幸运会员！");
				 }
			 }else{
				System.out.println("您没有登录，不能抽奖");
			 }
			 break;
		default:
			System.out.println("[您的输入有误！]");
			break;
		}
		System.out.println("继续吗？(y/n):");
		answer = input.next();
		}
		System.out.println("系统退出，谢谢使用！");
	}
}