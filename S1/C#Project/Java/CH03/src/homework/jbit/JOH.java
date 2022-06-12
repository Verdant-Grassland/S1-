package homework.jbit;

import java.util.Scanner;

public class JOH {
	
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("输入一个数：");
		int num=input.nextInt();
		if(num%2==0){
			System.out.println("这个数是偶数");
		}else{
			System.out.println("这个数不是偶数");
		}
	}
}
