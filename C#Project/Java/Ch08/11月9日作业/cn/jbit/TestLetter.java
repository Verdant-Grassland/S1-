package cn.jbit;

import java.util.Scanner;

public class TestLetter {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("������һ����ĸ:");
		char letter = input.next().charAt(0);
		if(letter >= 97 && letter <= 122){
			System.out.println("�������Сд��ĸ");
			letter = (char)(letter - 32);
			System.out.println("����Ϊ��д��ĸ��:" + letter);
		}else{
			System.out.println("������Ǵ�д��ĸ");
		}
	}
}
