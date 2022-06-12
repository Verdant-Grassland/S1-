package homework.jbit;

import java.util.Scanner;

public class CRQ {
	
	public static void main(String[] args) {
		Scanner input =new Scanner(System.in);
		System.out.println("请输入一个英文字母:");
		char A=input.next().charAt(0);
		switch(A){
		case 'M':
			System.out.println("Monday");
			break;
		case 'T':
			System.out.println("Tuesday");
			break;
		case 'W':
			System.out.println("Wednesday");
			break;
		case 't':
			System.out.println("Thursday");
			break;
		case 'F':
			System.out.println("Friday");
			break;
		case 'S':
			System.out.println("Saturday");
			break;
		case 'N':
			System.out.println("Sunday");
			break;
		}
	}
}