package ʮһ��ʮ�������翼��;

import java.util.Scanner;

public class shopping {

	/**
	 * 2000�����ڴ�9�ۣ�
	 * 4000�����ڴ�8�ۣ�
	 * 8000�����ڴ�7.5�ۣ�
	 * 8000�����ϴ�7�ۣ�
	 * ʹ��if-else-if�ṹ��ʵ���ֶ����빺����ͻ��֣������Ӧϴ���
	 */
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("�������:");
		int score = input.nextInt();
		System.out.println("������:");
		int money = input.nextInt();
		if(score<2000){
			System.out.println(money * 0.9);
		}else if(score<4000){
			System.out.println(money * 0.8);
		}else if(score<8000){
			System.out.println(money * 0.75);
		}else{
			System.out.println(money * 0.7);
		}
	}
}
