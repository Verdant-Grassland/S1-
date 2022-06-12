package 十一月十三日下午考试;

import java.util.Scanner;

public class shopping {

	/**
	 * 2000分以内打9折，
	 * 4000分以内打8折，
	 * 8000分以内打7.5折，
	 * 8000分以上打7折，
	 * 使用if-else-if结构，实现手动输入购物金额和积分，计算出应洗金额
	 */
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入积分:");
		int score = input.nextInt();
		System.out.println("输入金额:");
		int money = input.nextInt();
		if(score<2000){
			System.out.println(money * 0.9);
		}else if(score<4000){
			System.out.println(money * 0.8);
		}else if(score<8000){
			System.out.println(money * 0.75);
		}else{
			System.out.println(money * 0.7);
		}
	}
}
