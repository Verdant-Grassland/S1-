package homework.jbit;

import java.util.Scanner;

public class Console02 {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入小明期盼收到压岁钱数：");
		int score = input.nextInt();
		if (score == 1000){
			System.out.println("他捐助失学儿童");
		}else if (score < 1000 && score >= 500){
			System.out.println("他购买航模");
		}else if (score < 500){
			System.out.println("他购买百科全书");
		}
	}

}
