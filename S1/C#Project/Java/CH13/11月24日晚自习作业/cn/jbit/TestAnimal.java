package cn.jbit;

import java.util.Scanner;

public class TestAnimal {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Animal animal = new Animal();
		System.out.println("���붯����:");
		String name = input.next();
		String names = animal.show(name);
		System.out.println("����Ľ���Ϊ:" + names);
	}
}
