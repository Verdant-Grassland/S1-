package cn.jbit;

import java.util.Arrays;

import java.util.Scanner;

public class TesstArrays02 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int[] num = new int[5];
		for(int i = 0 ; i<num.length ; i++){
			System.out.println("�����" + (i + 1) + "��ͬѧ�ķ���:");
			num[i]= input.nextInt();
		}
		System.out.print("�Ӹߵ�������");
		Arrays.sort(num);
		for(int i = num.length-1 ; i >= 0 ; i--){
			System.out.print(num[i] + "\t");
		}
	}
}
