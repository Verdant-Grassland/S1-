package cn.jbit;

import java.util.Scanner;

public class Discount02 {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("�����Ա���µ����Ѽ�¼");
		double[] num = new double[5];
		double money = 0;
		for(int i = 0 ; i<num.length ; i++){
			System.out.println("�������" + (i + 1) + "�ʹ�����:");
			num[i] = input.nextDouble();
			money = money + num[i];
		}
		System.out.println("���" + "\t" + "���(Ԫ)");
		for(int i = 0 ; i<num.length ; i++){
			System.out.println((i + 1) + "\t" + num[i]);
		}
		System.out.println("�ܽ��" + "\t" + money);
	}
}