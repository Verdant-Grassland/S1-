package cn.jbit;

import java.util.Scanner;

public class TestMuch03 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("请输入的九九乘法表行数:");
		int num = input.nextInt();
		for(int i = 1; i <= num; i++){
			for(int ij = 1; ij <= i; ij++){
				System.out.print(ij + "*" + i + "=" + ij * i + "   ");
			}
			System.out.println();
		}
	}
}
