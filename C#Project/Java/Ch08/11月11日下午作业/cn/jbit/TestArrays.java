package cn.jbit;

import java.util.Arrays;

public class TestArrays {

	public static void main(String[] args) {
		char[] letter = new char[]{'a','c','u','b','e','p','f','z'};
		System.out.print("ԭ�ַ�����:");
		for(int i = 0 ; i<letter.length ; i++){
			System.out.print(letter[i] + "\t");
		}
		Arrays.sort(letter);
		System.out.print("\n���������:");
		for(int i = 0 ; i<letter.length ; i++){
			System.out.print(letter[i] + "\t");
		}
		System.out.print("\n�������Ϊ:");
		for(int i = letter.length-1; i >= 0 ; i--){
			System.out.print(letter[i] + "\t");
		}
	}
}
