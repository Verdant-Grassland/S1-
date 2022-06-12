package homework.jbit;

import java.util.Scanner;

public class Student {

	public static void main(String[] args) {
		Scanner input =new Scanner(System.in);
		System.out.println("输入成绩分数的等级:");
		int Chengji = input.nextInt();
		if (Chengji>=85 && Chengji<=100){
			System.out.println("A");
		}else if(Chengji>=74 && Chengji<=84){
			System.out.println("B");
		}else if(Chengji>=60 && Chengji<=69){
			System.out.println("C");
		}else{
			System.out.println("D");
		}
	}
}