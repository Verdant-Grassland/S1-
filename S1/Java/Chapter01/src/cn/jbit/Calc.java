package cn.jbit;

import java.util.Scanner;

public class Calc {
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("����STB�ɼ�");
		int stb=input.nextInt();
		System.out.println("����java�ɼ���");
		int java=input.nextInt();
		System.out.println("����sql�ɼ���");
		int sql=input.nextInt();
		System.out.println("------------------------------");
		System.out.println("STB\tJAVA\tSQL");
		System.out.println(stb+"\t"+java+"\t"+sql);
		
		System.out.println("------------------------------");
		int diffen=java-sql;
		double avg=(stb+java+sql)/3;
		System.out.println("java��sql֮��"+diffen);
		System.out.println("ƽ������"+avg);
	}
}
