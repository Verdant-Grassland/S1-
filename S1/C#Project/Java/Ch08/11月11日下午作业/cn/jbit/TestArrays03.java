package cn.jbit;

import java.util.Scanner;

public class TestArrays03 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int sum = 0;
		double[] num = new double[]{85,74,96,35,58,47,12,34,85,69};
		for(int i = 0 ; i<num.length ; i++){
			System.out.print(num[i] +"\t");
		}
		for(int i = 0 ; i<num.length ; i++){
			if(num[i]%5 == 0){
				sum++;
			}
		}
		System.out.println("\n被5整数的个数");
	}
}
