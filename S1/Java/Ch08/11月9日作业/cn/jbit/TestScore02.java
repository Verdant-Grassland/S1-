package cn.jbit;

import java.util.Scanner;

public class TestScore02 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("�������Ŀ��Գɼ�:");
		int score = input.nextInt();
		if(score >= 90 && score <= 100){
			System.out.println("����");
		}else if(score >= 80 && score <= 89){
			System.out.println("����");
		}else if(score >= 70 && score <= 79){
			System.out.println("�е�");
		}else if(score >= 60 && score <= 69){
			System.out.println("����");
		}else{
			System.out.println("������");
		}
	}
}
