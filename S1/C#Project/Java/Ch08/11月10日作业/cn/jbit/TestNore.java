package cn.jbit;

import java.util.Scanner;

public class TestNore {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = 0;
		for(int i = 1 ; i <= 10 ; i++){
			System.out.println("��ֱ������" + i + "��ͬѧ�ĳɼ�:");
			int score = input.nextInt();
			if(score >= 90){
				num++;
			}
		}
		double bord = (num / 10.0) * 100;
		System.out.println("����90��ͬѧ�ĳɼ���:" + num);
		System.out.println("����90�ֵı�����:" + bord + "%");
	}
}
