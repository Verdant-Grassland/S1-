package com.sun.corba.se.impl.logging;

import java.io.InputStream;

import java.util.Scanner;

public class Systen {

	public Systen(InputStream in) {
		Scanner input = new Scanner(System.in);
		System.out.println("�������ı�������:");
		int age = input.nextInt();
		System.out.println(age + "666");
	}

}
