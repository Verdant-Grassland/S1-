package cn.jbit;

import java.util.Scanner;

public class SDF2 {
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("����ְָ���Ǯ����");
		int score = input.nextInt();
		if (score>=1000001&&score<=5000000) {
			System.out.println("�ְָ�����");
		} else if (score>=500001&&score<=1000000) {
			System.out.println("�ְָ��������");
		} else if (score>=100001&&score<=500000) {
			System.out.println("�ְָ�������");
		} else if (score>=1&&score<=100000) {
			System.out.println("�ְָ��Һ͸��Ǯ���ϵ�");
		}
	}
}
