package homework.jbit;

import java.util.Scanner;

public class Console01 {
	
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.print("�����ϰ�ʱ������");
		int score = input.nextInt();
		if(score>=76&&score<=90){
			System.out.print("ÿСʱ40");
		}else if(score>=61&&score<=75){
			System.out.println("ÿСʱ30");
		}else if(score>=0&&score<60){
			System.out.println("ÿСʱ20");
		}
	}
}
