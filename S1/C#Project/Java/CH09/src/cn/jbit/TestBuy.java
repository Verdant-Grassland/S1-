package cn.jbit;

import java.util.Scanner;

public class TestBuy {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int count = 0;
		for(int i = 1 ; i <= 5 ; i++){
			System.out.println("\n��ӭ���ٵ�" + i + "���·�ר����:");
			for(int j = 1 ; j <= 3 ; j++){
				System.out.print("Ҫ�뿪��(y/n)?");
				String answer = input.next();
				if(answer.equals("y")){
					System.out.println("������");
					break;
				}
				System.out.println("����һ���·�");
				count++;
			}
		}
		System.out.println("�ܹ�������" + count + "���·�");
	}
}
