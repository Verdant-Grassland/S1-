package cn.jbit;

import java.util.Scanner;

public class TestNad {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入一批数:");
		int num = input.nextInt();
		int had = 0;
		for(int i = 1 ; i <= num ; i++){
			if(num > 0 && num%2 == 0){
				had = had + i;
			}
		}
		System.out.println(had);
	}
}