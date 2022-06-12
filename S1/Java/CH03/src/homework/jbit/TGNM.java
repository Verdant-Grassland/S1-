package homework.jbit;

import java.util.Scanner;

public class TGNM {
	
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.print("袋子里有几个坏鸡蛋：");
		int score = input.nextInt();
		if(score>5){
			System.out.println("我要去退掉这些鸡蛋");
		}else if(score<5){
			System.out.println("我要吃掉这些鸡蛋");
		}
		}
	}