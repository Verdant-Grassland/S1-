package cn.jbit;

import java.util.Scanner;

public class console2 {

	public static void main(String[] args){
		int liSi = 80;          //ѧԱ���ĳɼ�
		boolean isBig ;           
		Scanner input = new Scanner(System.in);   
		System.out.print("����ѧԱ�����ɼ�: ");       
		int zhangSan =  input.nextInt();                     //���������ĳɼ�      
		isBig = zhangSan > liSi ; 
		boolean isSmall = zhangSan <liSi ; 
		System.out.println( "�����ɼ������ĸ��� �� "+isBig );    //����ȽϽ��

	}

}