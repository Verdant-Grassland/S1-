package homework.jbit;

import java.util.Scanner;

public class Console03 {
	
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("假期数字：");
		int score=input.nextInt();
		if(score<7){
			System.out.println("出去旅游");
		}else{
			System.out.println("在家休息");
		}
	}
}
