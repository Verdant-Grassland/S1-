package cn.jbit;

import java.util.Scanner;

public class TestMuch {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("������ֱ�������ε�����:");
		int num = input.nextInt();
		for(int i = 1 ; i <= num ;i++){
			for(int ij = 1 ; ij <= 2 * i - 1 ; ij++){
					System.out.print("*");
			}
			System.out.println();
		}
	}
}