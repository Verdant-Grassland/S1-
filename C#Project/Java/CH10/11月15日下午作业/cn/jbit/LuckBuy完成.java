package cn.jbit;

import java.util.Scanner;

public class LuckBuy完成 {

	public static void main(String[] args) {
		String answer = "y";
		String userName = "";
		String password = "";
		int cardNumber = 0;
		boolean isRegister = false;
		boolean isLogin = false;
		int max = 9999;
		int min = 1000;
		Scanner input = new Scanner(System.in);
		do {
			System.out.println("*****欢迎进入奖客富翁系统*****");
			System.out.println("\t1.注册");
			System.out.println("\t2.登录");
			System.out.println("\t3.抽奖");
			System.out.println("***************************");
			System.out.print("请选择菜单：");
			int choice = input.nextInt();
			switch (choice) {
			case 1:
				System.out.println("[奖客富翁系统 > 注册]");
				System.out.println("请填写个人注册信息：");
				System.out.print("用户名：");
				userName = input.next();
				System.out.print("密码：");
				password = input.next();
				cardNumber = (int)(Math.random()*(max-min))+min;
				System.out.println("\n注册成功，请记好您的会员卡号");
				System.out.println("用户名\t密码\t会员卡号");
				System.out.println(userName + "\t" + password + "\t" + cardNumber);
				isRegister = true;
				break;
			case 2:
				System.out.println("[奖客富翁系统 > 登录]");
				if (isRegister){
					for (int i = 1; i <= 3; i++){
						System.out.print("请输入用户名：");
						String inputName = input.next();
						System.out.print("请输入密码：");
						String inputPassword = input.next();
						if (userName.equals(inputName) && password.equals(inputPassword)){
							System.out.println("\n欢迎您：" + userName);
							isLogin = true;
							break;
						}else if (i < 3){
							System.out.println("用户名或密码错误，还有" + (3 - i) + "次机会！");
						}else{
							System.out.println("您3次均输入错误！");
						}
					}
				}else{
					System.out.println("请先注册，再登录！");
				}
				break;
			case 3:
				System.out.println("[奖客富翁系统 > 抽奖]");
				if (!isLogin){
					System.out.println("请先登录，再抽奖！");
					System.out.println("继续吗？（y/n）");
					answer = input.next();
				}else{
					int[] luckynums = new int[5];
				    for(int i = 0; i < luckynums.length; i++){
				    	luckynums[i] = (int)(Math.random()*(max-min))+min;
				    }
					System.out.print("请输入您的卡号：");
					int yourcard = input.nextInt();
					int i;
					System.out.print("\n本日的幸运数字为：");
					for (i = 0; i < luckynums.length; i++){
						System.out.print(luckynums[i] + "  ");
					}
					for (i = 0; i < luckynums.length; i++){
						if (luckynums[i] == yourcard) {
							System.out.println("\n恭喜！您是本日的幸运会员！");
							break;
						}
					}
					if (i == luckynums.length) {
						System.out.println("\n抱歉！您不是本日的幸运会员！");
					}
				}
				break;
			default:
				System.out.println("[您的输入有误！]");
				break;
			}
			System.out.print("继续吗？（y/n）:");
			answer = input.next();
			System.out.println("");
		} while ("y".equals(answer));
		if ("n".equals(answer)){
			System.out.println("系统退出，谢谢使用！");
		}
	}
}
