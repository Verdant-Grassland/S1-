package cn.jbit;

import java.util.Scanner;

public class TestMyTime {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		MyTime time = new MyTime();
		System.out.println("??????ʱ??:");
		time.times = input.nextInt();
		String Tim = time.getInfo();
		System.out.println(Tim);
	}
}
