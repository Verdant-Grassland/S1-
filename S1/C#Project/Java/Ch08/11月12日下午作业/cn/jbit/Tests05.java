package cn.jbit;

import java.util.Scanner;

public class Tests05 {

	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		String[] name = new String[]{"李佔峰","wmy","zzt","dst","wzy","wqt"}; 
		System.out.print("同学的姓名:");
		for(int i = 0 ; i<name.length ; i++){
			System.out.print(name + "\t");
		}
		System.out.println("\n輸入查找的姓名:");
		String classmates = input.next();
		for(int i = 0 ; i<name.length ; i++){
			if(classmates == name[i]){
				System.out.println("该学员在此班");
			}else{
				System.out.println("没有找到");
			}
		}
	}
}
