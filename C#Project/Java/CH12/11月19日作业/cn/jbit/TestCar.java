package cn.jbit;

import java.util.Scanner;

public class TestCar {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Car Drive = new Car();
		System.out.println("�������ĳ�Ʒ������:");
		Drive.name = input.next();
		System.out.println("�������ĳ���ɫ:");
		Drive.color = input.next();
		Drive.show();
		Drive.Run();
		Drive.stop();
	}
}