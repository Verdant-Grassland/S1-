package homework.jbit;

import java.util.Scanner;

public class Calc {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("���������:");
		char ch = input.next().charAt(0);
		int a = 120;
		int b = 100;
		switch(ch){
				case'+':
					System.out.println("���:");
					System.out.println(a+b);
					break;
				case'-':
					System.out.println("���:");
					System.out.println(a-b);
					break;
				case'*':
					System.out.println("���:");
					System.out.println(a*b);
					break;
				case'/':
					System.out.println("���:");
					System.out.println(a/b);
					break;
		}
	}
}
