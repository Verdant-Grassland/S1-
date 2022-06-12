package cn.jbit;

import java.util.Scanner;

public class TestNore {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		int num = 0;
		for(int i = 1 ; i <= 10 ; i++){
			System.out.println("请分别输入第" + i + "个同学的成绩:");
			int score = input.nextInt();
			if(score >= 90){
				num++;
			}
		}
		double bord = (num / 10.0) * 100;
		System.out.println("大于90分同学的成绩是:" + num);
		System.out.println("大于90分的比例是:" + bord + "%");
	}
}
