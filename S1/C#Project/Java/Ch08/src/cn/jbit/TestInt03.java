package cn.jbit;

import java.util.Scanner;

public class TestInt03 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		boolean isOk = false;
		System.out.println("����һ����:");
		int tum = input.nextInt();
		int []num = new int[]{8,4,2,1,23,344,12};
		System.out.println("ѭ���������е�ֵ");
		for(int i = 0 ; i<num.length ; i++){
		if(tum == num[i]){
			isOk = true;
			break;
			}
		}
		if(isOk){
			System.out.println("�¶���");
		}else{
			System.out.println("�´���");
			
		}
	}
}
