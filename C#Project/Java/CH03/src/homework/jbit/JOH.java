package homework.jbit;

import java.util.Scanner;

public class JOH {
	
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("����һ������");
		int num=input.nextInt();
		if(num%2==0){
			System.out.println("�������ż��");
		}else{
			System.out.println("���������ż��");
		}
	}
}
