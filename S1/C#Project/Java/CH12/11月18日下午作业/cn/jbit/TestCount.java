package cn.jbit;

import java.util.Scanner;

public class TestCount {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int[] num = new int[10];
		int[] count = new int[4];
		System.out.println("请输入10个数:");
		for(int i = 0; i < num.length; i++){
			num[i] = input.nextInt();
			if(num[i] == 1){
				count[0]++;
			}else if(num[i] == 2){
				count[1]++;
			}else if(num[i] == 3){
				count[2]++;
			}else{
				count[3]++;
//			switch(num[i]){
//			case 1:
//				count[0]++;
//				break;
//			case 2:
//				count[1]++;
//				break;
//			case 3:
//				count[2]++;
//				break;
//			default:
//				count[3]++;
//				break;
			}
		}
		System.out.println("数字 1 的个数：" + count[0]);
		System.out.println("数字 2 的个数：" + count[1]);
		System.out.println("数字 3 的个数：" + count[2]);
		System.out.println("非法数字的个数：" + count[3]);
	}
}
