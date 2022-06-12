package homework.jbit;

import java.util.Scanner;

public class Calc {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("输入运算符:");
		char ch = input.next().charAt(0);
		int a = 120;
		int b = 100;
		switch(ch){
				case'+':
					System.out.println("相加:");
					System.out.println(a+b);
					break;
				case'-':
					System.out.println("相减:");
					System.out.println(a-b);
					break;
				case'*':
					System.out.println("相乘:");
					System.out.println(a*b);
					break;
				case'/':
					System.out.println("相除:");
					System.out.println(a/b);
					break;
		}
	}
}
