package cn.jbit;

import java.util.Scanner;

public class user {
	
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		System.out.println("����4λ�Ļ�Ա�ţ�");
		int num=input.nextInt();
		if(num>=1000 && num<=9999){
			System.out.println("�����Ա�����գ�");
			String birthday=input.next();
			System.out.println("�����Ա�Ļ��֣�");
			int point=input.nextInt();
			System.out.println("\n��¼��Ļ�Ա��Ϣ�ǣ�");
			System.out.println(num+"\t"+birthday+"\t"+point);
		}else{
			System.out.println("�����Ա���Ų���ȷ��������4λ�Ļ�Ա����");
		}
	}
}
