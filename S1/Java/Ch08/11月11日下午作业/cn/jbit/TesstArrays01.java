package cn.jbit;

import java.util.Scanner;

public class TesstArrays01 {

     	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int[] num = new int[]{10,30,50,70,90,60};
		System.out.println("输入一个整数:");
		int nad = input.nextInt();
		boolean sum = false;
		for(int i = 0 ; i<num.length ; i++){
			if(nad == num[i]){
				sum = true;
				System.out.println(num[i]);
				break;
			}
		}
		for (int i = 0; i < num.length; i++) {
			if (sum) {
				System.out.println(num[i]);
			}else{
				System.out.println("-1");
				break;
			}
		}

	}
}