package cn.jbit;

import java.util.Scanner;

public class TestVehicle0 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Vehicle bux = new Vehicle();
		System.out.println("���������ٶ�:");
		bux.speed = input.next();
		System.out.println("�����������:");
		bux.Size = input.next();
		bux.show();
	}
}
