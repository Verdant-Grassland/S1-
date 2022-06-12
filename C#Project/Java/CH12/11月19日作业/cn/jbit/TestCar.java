package cn.jbit;

import java.util.Scanner;

public class TestCar {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Car Drive = new Car();
		System.out.println("输入您的车品牌名称:");
		Drive.name = input.next();
		System.out.println("输入您的车颜色:");
		Drive.color = input.next();
		Drive.show();
		Drive.Run();
		Drive.stop();
	}
}