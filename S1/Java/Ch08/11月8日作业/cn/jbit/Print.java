package cn.jbit;

import java.util.Scanner;

public class Print {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int a = 0;
		for(int i = 100 ; i <= 999 ; i++){
			int b = i/100%10;
			int c = i/10%10;
			int d = i%10;
			if(b*b*b + c*c*c + d*d*d == i){
				System.out.println(i + "是水仙花数");
			}
		}
	}
}
