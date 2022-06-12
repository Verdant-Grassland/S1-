package cn.jbit;

import java.util.Scanner;

public class GoodLuck {

	/**
	 * 幸运抽奖
	 */
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		String answer="y";
		while(answer.equals("y")){
			System.out.println("**********欢迎进入奖客富翁系统*************************");
			System.out.println("\t\t1.注册");
			System.out.println("\t\t2.登录");
			System.out.println("\t\t3.抽奖");
			System.out.println("***********************************************");
			System.out.println("请选择菜单:");
			int choose=input.nextInt();
			//用户名
			String name="";
			//密码
			String pwd="";
			//最大值
			int max=9999;
			//最小值
			int min=1000;
			//随机的四位会员卡号
			int cardNo=(int)(Math.random()*(max-min))+min;
			//是否注册成功的标识位
			boolean isReg=false;
			switch(choose){
			case 1:
				System.out.println("[奖客富翁系统>注册]");
				System.out.println("请输入用户名：");
				name=input.next();
				System.out.println("请输入密码：");
				pwd=input.next();
				
				System.out.println("\n注册成功，请记好会员卡号");
				System.out.println("用户名\t密码\t会员卡号");
				System.out.println(name+"\t"+pwd+"\t"+cardNo);
				//isReg为true表示注册成功，false注册失败
				isReg=true;
				break;
			case 2:
				System.out.println("[奖客富翁系统>登录]");
				if(isReg){
					
				}else{
					System.out.println("您还没有注册呢？不能登录");
				}
				break;
			case 3:
				System.out.println("[奖客富翁系统>抽奖]");
				break;
			default:
				System.out.println("没有此选项");
				break;
			}
			System.out.print("继续吗？(y/n)");
			answer=input.next();
		}
		System.out.println("退出系统，谢谢使用");
		
	}

}
