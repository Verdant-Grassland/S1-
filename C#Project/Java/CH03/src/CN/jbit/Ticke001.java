package cn.jbit;

import java.util.Scanner;

public class Ticke001 {
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("�����򳵣���ʲô�������������������ж��ٴ��");
		int score=input.nextInt();
		if(score>=500){
			System.out.println("����");
		}else if(score>=100){
			System.out.println("������ϣ������");
		}else if(score>=50){
			System.out.println("��ȥŷ������");
		}else if(score>=10){
			System.out.println("������һ�����");
		}else if(score<=10){
			System.out.println("�����ո���");
		}
	}
}

