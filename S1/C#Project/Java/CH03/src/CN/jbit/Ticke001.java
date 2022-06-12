package cn.jbit;

import java.util.Scanner;

public class Ticke001 {
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("我想买车，买什么车决定于于我在银行有多少存款");
		int score=input.nextInt();
		if(score>=500){
			System.out.println("我买车");
		}else if(score>=100){
			System.out.println("我资助希望工程");
		}else if(score>=50){
			System.out.println("我去欧洲旅游");
		}else if(score>=10){
			System.out.println("我买下一期体彩");
		}else if(score<=10){
			System.out.println("继续烧高香");
		}
	}
}

