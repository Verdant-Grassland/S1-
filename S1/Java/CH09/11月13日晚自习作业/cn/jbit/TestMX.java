package cn.jbit;

import java.util.Scanner;

public class TestMX {

	/**
	 * �Ӽ���������10�����������ݴ��������У����������������ֵ���±�
	 */
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		int []num=new int [10];
		for(int i=0;i<num.length;i++){
			System.out.println("�������"+(i+1)+"����:");
			num[i]=input.nextInt();		
		}
		int max=num[0];
		int sum=0;
		for(int i=0;i<num.length;i++){
			if(max<num[i]){
				max=num[i];
				sum=i;
			}
		}
		for(int i=0;i<num.length;i++){
			System.out.print(num[i]+"\t");
		}
		System.out.println("\n�±�Ϊ"+sum);
		System.out.println("���ֵ"+max);
	}
}
