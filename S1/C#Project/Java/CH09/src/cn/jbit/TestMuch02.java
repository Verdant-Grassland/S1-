package cn.jbit;

import java.util.Scanner;

public class TestMuch02 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("请输入直角三角形的行数:");
		int num = input.nextInt();
		for(int i = 1 ; i <= num ;i++){
			for(int ij = 1 ; ij <= num + 1 - i ; ij++){
					System.out.print("*");
			}
			System.out.println();
		}
	}
}
