package homework.jbit;

import java.util.Scanner;

public class Customer {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入会员的积分:");
		int VIPprocal = input.nextInt();
		if(VIPprocal <=1000 && VIPprocal >= 100){
			System.out.println("普卡");
		}else if(VIPprocal <=3000 && VIPprocal >= 1001){
			System.out.println("银卡");
		}else if(VIPprocal <=5000 && VIPprocal >= 3001){
			System.out.println("金卡");
		}
	}
}
