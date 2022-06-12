package cn.jbit;

import java.util.Scanner;

public class TestVehicle0 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Vehicle bux = new Vehicle();
		System.out.println("输入您的速度:");
		bux.speed = input.next();
		System.out.println("输入您的体积:");
		bux.Size = input.next();
		bux.show();
	}
}
