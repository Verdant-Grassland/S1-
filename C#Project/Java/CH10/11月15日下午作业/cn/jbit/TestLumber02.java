package cn.jbit;

import java.util.Scanner;

public class TestLumber02 {

	/**
	 * ��д������Ϸ������һ�����������û������������������Ƚ�������С�������û��´��˻���С�ˣ����������10�Ρ�����û��¶��ˣ��û���ʤ������������õ�����
	 */
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = (int)(Math.random()*10);
		int a = 0;
		while(a<10){
			System.out.println("������������:");
			int enderNum = input.nextInt();
			if(enderNum > num){
				System.out.println("�´���");
				a++;
			}else if(enderNum == num){
				System.out.println("�¶���");
			}else{
				System.out.println("��С��");
				a++;
			}
		}
	}
}
