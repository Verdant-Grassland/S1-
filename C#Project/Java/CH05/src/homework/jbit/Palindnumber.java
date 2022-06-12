package homework.jbit;

import java.util.Scanner;

public class Palindnumber {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = input.nextInt();
		int wan = num/10000;
		int qian = num/1000%10;
		int bai = num/100%10;
		int shi = num/10%10;
		int ge = num%10;
		if(ge == wan && shi == qian){
			System.out.println(num+"是一个回文数");
		}else{
			System.out.println(num+"不是回文数");
		}
	}
}
