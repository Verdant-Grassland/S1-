package cn.jbit;

import java.util.Scanner;

public class TestBuySprice {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int count = 0;
		double price = 0.0;
		for(int i = 0 ; i < 3 ; i++){
			System.out.println("�������" + (i + 1) + "����������������Ʒ�ļ۸�:");
			for(int j = 0 ; j < 3 ; j++){
				price = input.nextInt();
				if(price < 300)
					continue;
				count++;
			}
			System.out.println("��" + (i+1) + "����" + count + "��Ʒ����8���Żݣ�");
			count = 0;
		}
	}
}
