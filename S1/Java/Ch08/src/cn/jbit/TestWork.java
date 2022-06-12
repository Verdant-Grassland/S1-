package cn.jbit;

import java.util.Scanner;

public class TestWork {

	public static void main(String[] args) {
		int[] num = new int[]{30,20,67,14,25};
		Scanner input = new Scanner(System.in);
		boolean flag = false;
		System.out.println("输入一个数:");
		int n = input.nextInt();
		for(int i = 0 ; i<num.length ; i++){
			if(num[i] == n){
				System.out.println(i);
				flag = true;
				break;
			}
		}
		if(!flag){
			System.out.println(-1);
		}
	}
}
