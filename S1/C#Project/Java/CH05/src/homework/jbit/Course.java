package homework.jbit;

import java.util.Scanner;

public class Course {
	
	public static void main(String[] args) {
		System.out.println("java");
		int i1 = new Scanner(System.in).nextInt();
		System.out.println("html");
	    int i2 = new Scanner(System.in).nextInt();
	    System.out.println("sql");
	    int i3 = new Scanner(System.in).nextInt();
	    System.out.println(sum(i1,i2,i3));
	}
	    private static <c> int sum(int a, int b, int c) {
	        return a+b+c;
	}
}
