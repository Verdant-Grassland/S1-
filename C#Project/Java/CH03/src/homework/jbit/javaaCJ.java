package homework.jbit;

import java.util.Scanner;

public class javaaCJ {
	
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("����java�ĳɼ�������");
		int score = input.nextInt();
		if(score>=85){
			System.out.print("����");
		}else if(score>=75){
			System.out.println("����");
		}else if(score>=60){
			System.out.println("����");
		}else{
			System.out.println("������");
		}
	}
}
