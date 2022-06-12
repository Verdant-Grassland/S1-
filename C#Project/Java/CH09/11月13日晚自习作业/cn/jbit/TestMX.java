package cn.jbit;

import java.util.Scanner;

public class TestMX {

	/**
	 * 从键盘上输入10个整数（数据存至数组中），求这组数的最大值及下标
	 */
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		int []num=new int [10];
		for(int i=0;i<num.length;i++){
			System.out.println("请输入第"+(i+1)+"个数:");
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
		System.out.println("\n下标为"+sum);
		System.out.println("最大值"+max);
	}
}
