package cn.jbit;

import java.util.Scanner;

public class TestAliquot {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("����һ����:");
		int num = input.nextInt();
		int qianwei = num/1000;
		int baiwei = num/100%10;
		int shiwei = num/10%10;
		int gewei = num%10;
		if(num%9 == 0 && (qianwei + baiwei + shiwei + gewei)%9 == 0){
			System.out.println("�ܱ�9����");
		}else{
			System.out.println("���ܱ�9����");
		}
	}
}
