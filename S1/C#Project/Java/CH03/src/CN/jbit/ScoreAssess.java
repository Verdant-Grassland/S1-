package cn.jbit;

import java.util.Scanner;

public class ScoreAssess {
	
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("���������");
		int score=input.nextInt();
		if(score>=80){
			System.out.println("����");
		}else if(score>=60){
			System.out.println("�е�");
		}else{
			System.out.println("��");
		}
	}
}
