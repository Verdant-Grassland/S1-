package homework.jbit;

import java.util.Scanner;

public class HMD {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("请输入当前的华氏温度：");
		double f = input.nextDouble();
		double c;
		c = 5/9.0*(f-32);
		System.out.println("\n当前的摄氏温度是: "+c);
	}
}
