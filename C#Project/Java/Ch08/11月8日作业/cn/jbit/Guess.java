package cn.jbit;

import java.util.Scanner;

public class Guess {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("����һ����:");
		int num1 = input.nextInt();
		int num2 = (int)(Math.random()*10);
		if(num1 > num2){
			System.out.println("�´��ˣ��������С");
		}else if(num1 < num2){
			System.out.println("�´��ˣ����������");
		}else if(num1 == num2){
			System.out.println("��ϲ�㣬�����");
		}
	}
}
