package cn.jbit;

import java.util.Scanner;

public class TestWork {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("���������ϰ�ʱ��:");
		int time = input.nextInt();
		System.out.println("�������Ĺ���:");
		int salary = input.nextInt();
		if(time <= 160){
			System.out.println("����ʱ����:" + time + "������Ϊ:" + time * salary);
		}else if(time > 160){
			System.out.println("����ʱ����:" + time + "������Ϊ:" + (160 * salary + (time - 160) * salary * 1.5));
		}
	}
}
