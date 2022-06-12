package other.jbit;

import java.util.Scanner;

public class fo {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int i = 10;
		int i2 = 10;
		double i1 = 5;
		double i3 = 5;
		System.out.println(i+i2/i+i3+"折");
		while(i <= 100) {
			i = i+i2;
			i3 = i3+2;
		}
		System.out.println("牛皮衣服"+i+"元");
		System.out.println("青年牛皮衣服"+i3+"元");
		System.out.println("总价:"+(i+i3)*0.16);
		System.out.println("给你"+i1+i2+"打折");
		System.out.println("总价："+i+i2/i+i3+"给你"+i1+i2+i3+"打折");
	}
}
