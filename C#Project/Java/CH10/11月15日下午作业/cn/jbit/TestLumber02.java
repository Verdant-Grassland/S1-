package cn.jbit;

import java.util.Scanner;

public class TestLumber02 {

	/**
	 * 编写猜数游戏：设置一个整数，请用户键盘输入猜想的数，比较两数大小，告诉用户猜大了还是小了，最多连续猜10次。如果用户猜对了，用户获胜；否则，输出设置的整数
	 */
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = (int)(Math.random()*10);
		int a = 0;
		while(a<10){
			System.out.println("输入猜想的数字:");
			int enderNum = input.nextInt();
			if(enderNum > num){
				System.out.println("猜大了");
				a++;
			}else if(enderNum == num){
				System.out.println("猜对了");
			}else{
				System.out.println("猜小了");
				a++;
			}
		}
	}
}
