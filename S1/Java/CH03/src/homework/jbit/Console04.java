package homework.jbit;

import java.util.Scanner;

public class Console04 {
	
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("����С�����Եķ�����");
		int score = input.nextInt();
		if(score>=85&&score<=90){
			System.out.print("����");
		}else if(score>=75&&score<=84){
			System.out.println("����");
		}else if(score>=60&&score<=74){
			System.out.println("����");
		}else  if(score<60){
			System.out.println("������");
		}
	}
}
