package cn.jbit;

import java.util.Scanner;

public class OfInsert {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		System.out.println("原字符序列:");
		char[] num = new char[9];
		num[0] = 'a';
		num[1] = 'b';
		num[2] = 'c';
		num[3] = 'e';
		num[4] = 'f';
		num[5] = 'p';
		num[6] = 'u';
		num[7] = 'z';
		int index = num.length;
		System.out.println("待插入的字符是:");
		for(int i = 0 ; i<num.length ; i++){
			System.out.print(num[i] + "\t");
		}
		System.out.println("\n输入字符:");
		char data = input.next().charAt(0);
		for(int i = 0 ; i<num.length ; i++){
			if(data < num[i]){
				index = i;
				break;
			}
		}
		for(int i = num.length-1 ; i>index ; i--){
			num[i] = num[i - 1];
			num[index] = data;
			System.out.println("插入的数据下标是:" + index);
			System.out.println("\n插入完数据后:");
			for(int k = 0 ; k<num.length ; k++){
				System.out.println(num[k] + "\t");
			}
		}
	}
}
