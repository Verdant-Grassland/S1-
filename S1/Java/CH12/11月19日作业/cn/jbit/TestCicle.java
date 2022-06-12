package cn.jbit;

import java.util.Scanner;

public class TestCicle {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Cicle cocle = new Cicle();
		System.out.println(" ‰»Î∞Îæ∂:");
		cocle.r = input.nextInt();
		double radius = cocle.Circular();
		System.out.println(radius);
	}
}
