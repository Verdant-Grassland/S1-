package cn.jbit;

import java.util.Scanner;

public class Student01 {
	public static void main(String[] args) {
		Scanner input = new Scanner (System.in);
		String[] num = new String[30];
		for(int i = 0;i <= num.length ; i++){
			System.out.println("输入第" + (i + 1) + "同学的名字");
			num[i] = input.next();
			if(i == 4){
				break;
			}
		}                         
		System.out.println("五位同学的名字为：");
		for(int i =0 ; i < num.length ; i++){
			System.out.print(num[i] + "\t");
		}
	}

}