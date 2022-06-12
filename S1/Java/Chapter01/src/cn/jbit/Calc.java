package cn.jbit;

import java.util.Scanner;

public class Calc {
	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("输入STB成绩");
		int stb=input.nextInt();
		System.out.println("输入java成绩：");
		int java=input.nextInt();
		System.out.println("输入sql成绩：");
		int sql=input.nextInt();
		System.out.println("------------------------------");
		System.out.println("STB\tJAVA\tSQL");
		System.out.println(stb+"\t"+java+"\t"+sql);
		
		System.out.println("------------------------------");
		int diffen=java-sql;
		double avg=(stb+java+sql)/3;
		System.out.println("java和sql之差"+diffen);
		System.out.println("平均分是"+avg);
	}
}
