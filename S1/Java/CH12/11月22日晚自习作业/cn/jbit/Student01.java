package cn.jbit;

import java.util.Scanner;

public class Student01 {
	public static void main(String[] args) {
		Scanner input = new Scanner (System.in);
		String[] num = new String[30];
		for(int i = 0;i <= num.length ; i++){
			System.out.println("�����" + (i + 1) + "ͬѧ������");
			num[i] = input.next();
			if(i == 4){
				break;
			}
		}                         
		System.out.println("��λͬѧ������Ϊ��");
		for(int i =0 ; i < num.length ; i++){
			System.out.print(num[i] + "\t");
		}
	}

}