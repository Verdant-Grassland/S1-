package homework.jbit;

import java.util.Scanner;

public class QOnumber {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入一个数:");
		int num = input.nextInt();
		double sum = 0;
		double i = 1;
		if(num%2 == 0){
			while(i <= num){
				if(i%2 == 0){
					sum = sum + 1/i;
				}
				i++;
			}
			System.out.println("偶数累加和是：" + sum);
		}else{
			while(i <= num){
				if(i%2 != 0){
					sum = sum + 1/i;
				}
				i++;
			}
			System.out.println("奇数累加和是：" + sum);
		}
	}
}
