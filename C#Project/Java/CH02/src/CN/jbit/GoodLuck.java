package cn.jbit;

import java.util.Scanner;

public class GOODLUCK {

	public static void main(String[] args){
		Scanner input=new Scanner(System.in);
		System.out.println("����4λ�Ļ�Ա���ţ�");
		int num=input.nextInt();
		int qianWei=num/1000;
		int baiWei=num/100%10;
		int shiWei=num/10%10;
		int geWei=num%10;
		
		int sum=qianWei+baiWei+shiWei+geWei;
		
		System.out.println("��Ա����"+num+"����λ��֮����:"+sum);
		System.out.println("�����˿ͻ���"+(sum>20));
	}
}