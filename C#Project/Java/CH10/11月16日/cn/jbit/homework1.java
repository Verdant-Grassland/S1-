package cn.jbit;

import java.util.Scanner;

public class homework1 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("ÊäÈëĞĞÊı:");
		int number = input.nextInt();
		for(int i = 1 ; i <= number ;i++){
		for(int j = 1; j <= i; j++){
				System.out.print(j);
			}
			System.out.print("\n");
		}
	}
}
