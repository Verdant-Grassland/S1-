package ʮһ��ʮ�������翼��;

import java.util.Scanner;

public class TestNum {

	/**
	 * �ֶ�����һ��4λ�������λ����֮��
	 */
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("����һ��4λ��:");
		int num = input.nextInt();
		int qianwei = num/1000;
		int baiwei = num/100%10;
		int shiwei = num/10%10;
		int gewei = num%10;
		int sum = qianwei + baiwei + shiwei + gewei;
		System.out.println("ǧλ:" + qianwei);
		System.out.println("ǧλ:" + baiwei);
		System.out.println("ǧλ:" + gewei);
		System.out.println("ǧλ:" + shiwei);
		System.out.println("��: + sum");
	}
}
