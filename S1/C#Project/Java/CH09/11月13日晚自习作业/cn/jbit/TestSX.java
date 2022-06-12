package cn.jbit;

import java.util.Scanner;

public class TestSX {

	/**
	 * 从键盘上输入5个同学的分数，存储至数组，求分数的最高分与最低分
	 */
	public static void main(String[] args) {
		Scanner input=new Scanner(System.in);
		int [] num=new int[5];
		for(int i=0;i<num.length;i++){
			System.out.println("请输入第"+(i+1)+"同学的分数:");
			num[i]=input.nextInt();
		}
		int max=num[0];
		int min=num[0];
		for(int i=0;i<num.length;i++){
			 if(max<num[i]){ 
				 max=num[i];
			 } 
		}
		System.out.println("最高分为:"+max);
		for(int i=0;i<num.length;i++){
			if(min>num[i]){
				min=num[i];
			}
		}
		System.out.println("最低分为"+min);
	}
}

