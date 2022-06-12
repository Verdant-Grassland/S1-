package cn.jbit;

import java.util.Scanner;

public class TestScore03 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int[] a = new int[4];
		for(int i = 0 ; i <= a.length ; i++){
			System.out.println("输入您的第" + (i + 1) +"个门课成绩:");
			a[i] = input.nextInt();
			if(a[i] < 60){
				System.out.println("fail");
			}else{
				System.out.println("pass");
			}
		}
	}
}
