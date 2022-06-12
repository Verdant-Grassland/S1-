package 十一月十三日下午考试;

import java.util.Scanner;

public class TestNum {

	/**
	 * 手动输入一个4位数，求各位数字之和
	 */
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入一个4位数:");
		int num = input.nextInt();
		int qianwei = num/1000;
		int baiwei = num/100%10;
		int shiwei = num/10%10;
		int gewei = num%10;
		int sum = qianwei + baiwei + shiwei + gewei;
		System.out.println("千位:" + qianwei);
		System.out.println("千位:" + baiwei);
		System.out.println("千位:" + gewei);
		System.out.println("千位:" + shiwei);
		System.out.println("和: + sum");
	}
}
