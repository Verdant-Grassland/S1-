package homework.jbit;

import java.util.Scanner;

public class Console01 {
	
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.print("输入上班时间数：");
		int score = input.nextInt();
		if(score>=76&&score<=90){
			System.out.print("每小时40");
		}else if(score>=61&&score<=75){
			System.out.println("每小时30");
		}else if(score>=0&&score<60){
			System.out.println("每小时20");
		}
	}
}
