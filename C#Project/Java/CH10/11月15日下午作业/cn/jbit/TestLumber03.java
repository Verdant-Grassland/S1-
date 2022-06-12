package cn.jbit;

import java.util.Scanner;

public class TestLumber03 {
	
	/**
	 * 编程输出如图所示的、由数字1~9组成的金字塔
	 */

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入行数的数字:");
		int num = input.nextInt();
		//for(int i = 1; i <= 9; i++){
		//for(int j = 9; j >= i; j--){
		for(int i = 1; i <= num; i++){
			for(int j = num; j >= i; j--){
				System.out.print(" ");
			}
			for(int k = 1; k <= i ; k++){
				System.out.print("" + k);
			}
			for(int l = i-1 ; l > 0 ; l--){
				System.out.print("" + l);
			}
			System.out.println();
		}
	}
}
