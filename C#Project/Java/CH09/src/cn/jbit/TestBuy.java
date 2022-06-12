package cn.jbit;

import java.util.Scanner;

public class TestBuy {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int count = 0;
		for(int i = 1 ; i <= 5 ; i++){
			System.out.println("\n欢迎光临第" + i + "家衣服专卖店:");
			for(int j = 1 ; j <= 3 ; j++){
				System.out.print("要离开吗？(y/n)?");
				String answer = input.next();
				if(answer.equals("y")){
					System.out.println("离店结帐");
					break;
				}
				System.out.println("买了一件衣服");
				count++;
			}
		}
		System.out.println("总共购买了" + count + "件衣服");
	}
}
