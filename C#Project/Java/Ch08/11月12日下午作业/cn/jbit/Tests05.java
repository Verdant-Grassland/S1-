package cn.jbit;

import java.util.Scanner;

public class Tests05 {

	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		String[] name = new String[]{"��׷�","wmy","zzt","dst","wzy","wqt"}; 
		System.out.print("ͬѧ������:");
		for(int i = 0 ; i<name.length ; i++){
			System.out.print(name + "\t");
		}
		System.out.println("\nݔ����ҵ�����:");
		String classmates = input.next();
		for(int i = 0 ; i<name.length ; i++){
			if(classmates == name[i]){
				System.out.println("��ѧԱ�ڴ˰�");
			}else{
				System.out.println("û���ҵ�");
			}
		}
	}
}
