package cn.jbit;

import java.util.Scanner;

public class TestSX {

	/**
	 * �Ӽ���������5��ͬѧ�ķ������洢�����飬���������߷�����ͷ�
	 */
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		int [] num=new int[5];
		for(int i=0;i<num.length;i++){
			System.out.println("�������"+(i+1)+"ͬѧ�ķ���:");
			num[i]=input.nextInt();
		}
		int max=num[0];
		int min=num[0];
		for(int i=0;i<num.length;i++){
			 if(max<num[i]){ 
				 max=num[i];
			 } 
		}
		System.out.println("��߷�Ϊ:"+max);
		for(int i=0;i<num.length;i++){
			if(min>num[i]){
				min=num[i];
			}
		}
		System.out.println("��ͷ�Ϊ"+min);
	}
}

